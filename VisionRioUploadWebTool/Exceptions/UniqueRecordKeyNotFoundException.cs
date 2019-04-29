using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Rio.UploadDesktopTool.Exceptions
{
    class UniqueRecordKeyNotFoundException : Exception
    {
        public UniqueRecordKeyNotFoundException()
        {

        }

        public UniqueRecordKeyNotFoundException(string message) 
            : base (message)
        { 

        }

        public UniqueRecordKeyNotFoundException(string message, Exception inner)
            : base(message, inner)
        {

        }

        public static UniqueRecordKeyNotFoundException SetMessageItems(string uniqueRecordKey)
        {
            string messageTemplate = "The following unique record key was not found: '{1}'";
            throw new UniqueRecordKeyNotFoundException(String.Format(messageTemplate, uniqueRecordKey));
        }
    }
}
