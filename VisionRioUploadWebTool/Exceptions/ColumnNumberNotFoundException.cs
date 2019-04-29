using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Rio.UploadDesktopTool.Exceptions
{
    class ColumnNumberNotFoundException : Exception
    {
        public ColumnNumberNotFoundException()
        {

        }

        public ColumnNumberNotFoundException(string message) 
            : base (message)
        { 

        }

        public ColumnNumberNotFoundException(string message, Exception inner)
            : base(message, inner)
        {

        }

        public static ColumnNumberNotFoundException SetMessageItems(string worksheetName, int columnNumber)
        {
            string messageTemplate = "The following column number was not found in the '{0}' worksheet: '{1}'";
            throw new ColumnNumberNotFoundException(String.Format(messageTemplate, worksheetName, columnNumber));
        }
    }
}
