using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Rio.UploadDesktopTool.Exceptions
{
    class UnableToAccessExcelFileException : Exception
    {
        public UnableToAccessExcelFileException()
        {

        }

        public UnableToAccessExcelFileException(string message) 
            : base (message)
        { 

        }

        public UnableToAccessExcelFileException(string message, Exception inner)
            : base(message, inner)
        {

        }

        public static UnableToAccessExcelFileException SetMessageItems(string filename)
        {
            string messageTemplate = "Having issues accessing the following file: '{0}'. Please make sure the specified file is closed, and that the appropriate dependencies are installed.";
            throw new UnableToAccessExcelFileException(String.Format(messageTemplate, filename));
        }

        public static UnableToAccessExcelFileException SetMessageItems(string filename, Exception ex)
        {
            string messageTemplate = "Having issues accessing the following file: '{0}'. Please make sure the specified file is closed, and that the appropriate dependencies are installed. \nInternal Message: {1}";
            throw new UnableToAccessExcelFileException(String.Format(messageTemplate, filename, ex.Message));
        }
    }
}
