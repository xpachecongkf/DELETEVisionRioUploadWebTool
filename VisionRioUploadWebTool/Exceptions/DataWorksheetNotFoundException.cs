using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Rio.UploadDesktopTool.Exceptions
{
    class DataWorksheetNotFoundException : Exception
    {
        public DataWorksheetNotFoundException()
        { 

        }

        public DataWorksheetNotFoundException(string message) 
            : base (message)
        { 

        }

        public DataWorksheetNotFoundException(string message, Exception inner)
            : base(message, inner)
        {

        }

        public static DataWorksheetNotFoundException SetMessageItems(string filename)
        {
            string messageTemplate = "The following Excel file is missing a data worksheet: {0}";
            throw new DataWorksheetNotFoundException(String.Format(messageTemplate, filename));
        }
    }
}
