using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vision.Rio.UploadDesktopTool.Exceptions
{
    class RioErrorException : Exception
    {
        public RioErrorException()
        {

        }

        public RioErrorException(string message) 
            : base (message)
        { 

        }

        public RioErrorException(string message, Exception inner)
            : base(message, inner)
        {

        }

        private static readonly Regex ErrorMessageRegex = new Regex("{\\s*\"ERROR\":\\s*\"[^\"]+\"\\s*}");

        public static void CheckResponseForError(string response)
        {
            if (ErrorMessageRegex.IsMatch(response))
            { 
                Models.Rio.Exception.RioErrorDto rioErrorDto =
                    JsonConvert.DeserializeObject<Models.Rio.Exception.RioErrorDto>(response);

                if (!String.IsNullOrWhiteSpace(rioErrorDto.ERROR))
                {
                    ThrowException(rioErrorDto.ERROR);
                }
            }
        }
        private static RioErrorException ThrowException(string errorMessage)
        {
            throw new RioErrorException(errorMessage);
        }
    }
}
