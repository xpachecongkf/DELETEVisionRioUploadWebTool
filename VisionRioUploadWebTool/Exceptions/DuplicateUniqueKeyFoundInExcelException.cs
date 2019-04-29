using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Rio.UploadDesktopTool.Exceptions
{
    class DuplicateUniqueKeyFoundInExcelException : Exception
    {
        public DuplicateUniqueKeyFoundInExcelException()
        {

        }

        public DuplicateUniqueKeyFoundInExcelException(string message) 
            : base (message)
        { 

        }

        public DuplicateUniqueKeyFoundInExcelException(string message, Exception inner)
            : base(message, inner)
        {

        }

        public static DuplicateUniqueKeyFoundInExcelException SetMessageItems(string uniqueKey)
        {
            string messageTemplate = "Duplicate unique key found ({0}) in Excel file, please make sure that all keys are unique in the Excel file.";
            throw new DuplicateUniqueKeyFoundInExcelException(String.Format(messageTemplate, uniqueKey));
        }
    }
}
