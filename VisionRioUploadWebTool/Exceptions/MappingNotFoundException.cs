using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Rio.UploadDesktopTool.Exceptions
{
    class MappingNotFoundException : Exception
    {
        public MappingNotFoundException()
        {

        }

        public MappingNotFoundException(string message) 
            : base (message)
        { 

        }

        public MappingNotFoundException(string message, Exception inner)
            : base(message, inner)
        {

        }

        public static MappingNotFoundException SetMessageItems(string worksheetName, string columnName)
        {
            string messageTemplate = "Mapping was not found for the following column in the '{0}' worksheet: '{1}'";
            throw new MappingNotFoundException(String.Format(messageTemplate, worksheetName, columnName));
        }
    }
}
