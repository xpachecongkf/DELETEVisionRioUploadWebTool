using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision.Rio.UploadDesktopTool.Models.Rio.Upload;

namespace Vision.Rio.UploadDesktopTool.Exceptions
{
    class InvalidRelationshipTypeException : Exception
    {
        public InvalidRelationshipTypeException()
        {

        }

        public InvalidRelationshipTypeException(string message) 
            : base (message)
        { 

        }

        public InvalidRelationshipTypeException(string message, Exception inner)
            : base(message, inner)
        {

        }

        public static InvalidRelationshipTypeException SetMessageItems(RelatedRecord relatedRecord)
        {
            string messageTemplate = "The following association type is not valid for the '{0}' worksheet: '{1}'";
            throw new InvalidRelationshipTypeException(String.Format(messageTemplate, relatedRecord.SrcWorksheetName, relatedRecord.Relationship.Type));
        }
    }
}
