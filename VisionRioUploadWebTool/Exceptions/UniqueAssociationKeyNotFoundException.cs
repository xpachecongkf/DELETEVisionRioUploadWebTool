using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Rio.UploadDesktopTool.Exceptions
{
    class UniqueAssociationKeyNotFoundException : Exception
    {
        public UniqueAssociationKeyNotFoundException()
        {

        }

        public UniqueAssociationKeyNotFoundException(string message) 
            : base (message)
        { 

        }

        public UniqueAssociationKeyNotFoundException(string message, Exception inner)
            : base(message, inner)
        {

        }

        public static UniqueAssociationKeyNotFoundException SetMessageItems(string uniqueRecordKey)
        {
            string messageTemplate = "The following unique association key was not found: '{1}'";
            throw new UniqueAssociationKeyNotFoundException(String.Format(messageTemplate, uniqueRecordKey));
        }
    }
}
