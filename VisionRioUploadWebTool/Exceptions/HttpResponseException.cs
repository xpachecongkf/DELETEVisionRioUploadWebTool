using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Rio.UploadDesktopTool.Exceptions
{
    class HttpResponseException : Exception
    {
        public HttpResponseException()
        {

        }

        public HttpResponseException(string message) 
            : base (message)
        { 

        }

        public HttpResponseException(string message, Exception inner)
            : base(message, inner)
        {

        }

        public static HttpResponseException SetMessageItems(int statusCode, string message)
        {
            string messageTemplate = "Status Code {0}: {1}";
            throw new HttpResponseException(String.Format(messageTemplate, statusCode, message));
        }
    }
}
