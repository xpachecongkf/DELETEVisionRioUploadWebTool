using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Rio.UploadDesktopTool.Exceptions
{
    class FieldMetaDataNotFoundException : Exception
    {
        public FieldMetaDataNotFoundException()
        {

        }

        public FieldMetaDataNotFoundException(string message) 
            : base (message)
        { 

        }

        public FieldMetaDataNotFoundException(string message, Exception inner)
            : base(message, inner)
        {

        }

        public static FieldMetaDataNotFoundException SetMessageItems
            (string worksheetName, string moduleName, string objectTypeName, string guiName, string dataSectionName,
            string fieldName)
        {
            string messageTemplate = "The following field meta data is not found, for the '{0}' worksheet, on the '{1}' -- '{2}' -- '{3}' form: '{4}' -- '{5}'";
            string message = String.Format(messageTemplate, worksheetName, moduleName, objectTypeName, guiName, dataSectionName, fieldName);
            throw new FieldMetaDataNotFoundException(message);
        }
    }
}
