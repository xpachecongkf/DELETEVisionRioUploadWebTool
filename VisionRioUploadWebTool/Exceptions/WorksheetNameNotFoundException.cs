using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Rio.UploadDesktopTool.Exceptions
{
    class WorksheetNameNotFoundException : Exception
    {
        public WorksheetNameNotFoundException()
        { 

        }

        public WorksheetNameNotFoundException(string message) 
            : base (message)
        { 

        }

        public WorksheetNameNotFoundException(string message, Exception inner)
            : base(message, inner)
        {

        }

        public static WorksheetNameNotFoundException SetMessageItems(string worksheetName)
        {
            string messageTemplate = "The following worksheet is missing from the Excel file: {0}";
            throw new WorksheetNameNotFoundException(String.Format(messageTemplate, worksheetName));
        }
    }
}
