using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Rio.UploadDesktopTool.Exceptions
{
    class ColumnNameNotFoundException : Exception
    {
        public ColumnNameNotFoundException()
        {

        }

        public ColumnNameNotFoundException(string message) 
            : base (message)
        { 

        }

        public ColumnNameNotFoundException(string message, Exception inner)
            : base(message, inner)
        {

        }

        public static ColumnNameNotFoundException SetMessageItems(string worksheetName, string columnName)
        {
            string messageTemplate = "The following column name was not found in the '{0}' worksheet: '{1}'";
            throw new ColumnNameNotFoundException(String.Format(messageTemplate, worksheetName, columnName));
        }
    }
}
