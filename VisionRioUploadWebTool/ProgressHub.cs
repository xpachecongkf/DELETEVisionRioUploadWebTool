using Microsoft.AspNet.SignalR;
using RioDummyDLL;
using RioDummyDLL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace VisionRioUploadWebTool
{


    public class UploadData
    {
        public int Method { get; set; }
        public string Message { get; set; }
        public int ProgressVal { get; set; }
    }

    public class ProgressHub : Hub
    {
        public delegate void Updater();

        //public void UploadSettingsFile(UploadData uploadData)
        //{

        //    //var rioMock = new RioMock();
        //    //rioMock.DoRioProcess(UpdaterCallback);

        //}

        //public void UploadTemplateFile(UploadData uploadData)
        //{
        //    //// call client-side SendMethod method
        //    //Clients.Caller.sendMessage(message);
        //}


        private Dummy Setup(ProgressAndStatus progressAndStatus)
        {
            //progressAndStatus.UserName = progressAndStatus.UserName; //  "iona.setup";
            //progressAndStatus.Password = progressAndStatus.Password; //  "Password";

            var basePath = AppDomain.CurrentDomain.BaseDirectory; // HttpContext.Server.MapPath("~");
            var settingsPath = basePath + "settings.xml";

            SettingsDto settingsDto = ObjectFactory.GenerateSettingsDto(settingsXmlFilePath: settingsPath);

            Dummy dummy = new Dummy(settingsDto, progressAndStatus);
            dummy.SetEnvironment(progressAndStatus.Environment);

            //TODO: Need to figure out login criteria
            dummy.SetUsernameAndPassword(progressAndStatus.UserName, progressAndStatus.Password);
            return dummy; 
        }

        public void Validate(ProgressAndStatus progressAndStatus)
        {

            //progressAndStatus.UserName = "iona.setup";
            //progressAndStatus.Password = "Password";
            progressAndStatus.Method = 1;

            var dummy = Setup(progressAndStatus);

            dummy.ValidateFile(
                inputFilePath: progressAndStatus.PhysicalDataFile, // original uploaded file
                outputFilePath: progressAndStatus.ValidationReportFile,  // original plus validation report
                callback: UpdaterCallback);
        }


        public void Process(ProgressAndStatus progressAndStatus)
        {

            progressAndStatus.Method = 2;

            var dummy = Setup(progressAndStatus);

            //progressAndStatus.Callback = UpdaterCallback;
            progressAndStatus.UploadReportFile = GetReportFileName(progressAndStatus.PhysicalDataFile);
            progressAndStatus.ValidationSuccess = progressAndStatus.SuccessProgress == Progress.prSuccess; 

            dummy.UploadFile(
                inputFilePath:  progressAndStatus.ValidationReportFile,
                outputFilePath: progressAndStatus.UploadReportFile,  //  original plus validation report + upload (process) report
                callback: UpdaterCallback);
        }


        public async Task ValidateAsync(ProgressAndStatus progressAndStatus)
        {

            //progressAndStatus.UserName = "iona.setup";
            //progressAndStatus.Password = "Password";
            progressAndStatus.Method = 1;

            var dummy = Setup(progressAndStatus);

            await dummy.ValidateFileAsync(
                inputFilePath: progressAndStatus.PhysicalDataFile,       // original uploaded file
                outputFilePath: progressAndStatus.ValidationReportFile,  // original plus validation report
                callback: UpdaterCallback);
        }


        public async Task ProcessAsync(ProgressAndStatus progressAndStatus)
        {

            progressAndStatus.Method = 2;

            var dummy = Setup(progressAndStatus);

            //progressAndStatus.Callback = UpdaterCallback;
            progressAndStatus.UploadReportFile = GetReportFileName(progressAndStatus.PhysicalDataFile);
            progressAndStatus.ValidationSuccess = progressAndStatus.SuccessProgress == Progress.prSuccess;

            await dummy.UploadFileAsync(
                inputFilePath: progressAndStatus.ValidationReportFile,
                outputFilePath: progressAndStatus.UploadReportFile,  //  original plus validation report + upload (process) report
                callback: UpdaterCallback);
        }


        public void UpdaterCallback(ProgressAndStatus progressAndStatus)
        {
            // call client-side SendMethod method
            Clients.Caller.sendMessage(progressAndStatus);
        }

        private string GetReportFileName(string inFileName)
        {
            string fileName = Path.GetFileNameWithoutExtension(inFileName);
            string filepath = Path.GetFullPath(inFileName);
            var newFileName = fileName + "_uplrpt";
            newFileName = filepath + newFileName + Path.GetExtension(inFileName);
            //newFileName = Path.Combine(Server.MapPath("~/App_Data"), newFileName);
            return newFileName;
        }
    }
}
