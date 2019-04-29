using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Rio.UploadDesktopTool.Exceptions
{
    class InvalidFileTypeException : Exception
    {
        public InvalidFileTypeException()
        { 

        }

        public InvalidFileTypeException(string message) 
            : base (message)
        { 

        }

        public InvalidFileTypeException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
