using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace VisionRioUploadWebTool.Controllers
{
    public class UploadController : Controller
    {


        public class UploadResponse
        {
            public string PhysicalFileName { get; set; }
            public string ValidationReportFile { get; set; }
            public bool IsError { get; set; }
            public string ErrorText { get; set; }
        }

        // GET: Update
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult RemoteDataSource_GetEnvironments(string text)
        {
            var path = HttpContext.Server.MapPath("~");
            path += "settings.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(formSettings));
            List<formSettingsEnvironment> environments;


            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                formSettings result = (formSettings)serializer.Deserialize(fileStream);
                environments = result.environments.ToList();
            }

            return Json(environments, JsonRequestBehavior.AllowGet);
        }

        private string GetPhysicalFileName(string inFileName)
        {
            string fileName = Path.GetFileNameWithoutExtension(inFileName);
            var newFileName = fileName + DateTime.Now.Ticks.ToString();
            newFileName += Path.GetExtension(inFileName);
            newFileName = Path.Combine(Server.MapPath("~/App_Data"), newFileName);
            return newFileName;
        }

        private string GetReportFileName(string inFileName)
        {
            string fileName = Path.GetFileNameWithoutExtension(inFileName);
            var newFileName = fileName + "_rpt";
            newFileName +=  Path.GetExtension(inFileName);
            newFileName = Path.Combine(Server.MapPath("~/App_Data"), newFileName);
            return newFileName;
        }

        public ActionResult AsyncUploadDataFile(HttpPostedFileBase uploadFile)
        {

            string fileName = string.Empty;
            // The Name of the Upload component is "files"
            if (uploadFile != null)
            {

                // Some browsers send file names with full path.
                // We are only interested in the file name.
                fileName = Path.GetFileName(uploadFile.FileName);
                //var physicalPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);

                fileName = GetPhysicalFileName(fileName);
                var physicalPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);

                uploadFile.SaveAs(physicalPath);
    
            }

            // Return an empty string to signify success

            UploadResponse ur = new UploadResponse()
            {
                ErrorText = "",
                IsError = false,
                PhysicalFileName = fileName,
                ValidationReportFile = GetReportFileName(fileName)
            };
            return Content(JsonConvert.SerializeObject(ur));
        }

        public ActionResult AsyncRemoveDataFile(string[] fileNames)
        {
            // The parameter of the Remove action must be called "fileNames"

            if (fileNames != null)
            {
                foreach (var fullName in fileNames)
                {
                    var fileName = Path.GetFileName(fullName);
                    var physicalPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);

                    // TODO: Verify user permissions

                    if (System.IO.File.Exists(physicalPath))
                    {
                        System.IO.File.Delete(physicalPath);
                    }
                }
            }

            // Return an empty string to signify success
            return Content("");
        }
    }
}