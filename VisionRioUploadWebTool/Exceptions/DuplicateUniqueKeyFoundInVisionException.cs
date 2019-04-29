using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Rio.UploadDesktopTool.Exceptions
{
    class DuplicateUniqueKeyFoundInVisionException : Exception
    {
        public DuplicateUniqueKeyFoundInVisionException()
        {

        }

        public DuplicateUniqueKeyFoundInVisionException(string message) 
            : base (message)
        { 

        }

        public DuplicateUniqueKeyFoundInVisionException(string message, Exception inner)
            : base(message, inner)
        {

        }

        public static DuplicateUniqueKeyFoundInVisionException SetMessageItems(string uniqueKey)
        {
            string messageTemplate = "Duplicate unique key found ({0}) in the Vision DB, please make sure that all keys are unique in the Vision DB.";
            throw new DuplicateUniqueKeyFoundInVisionException(String.Format(messageTemplate, uniqueKey));
        }
    }
}
