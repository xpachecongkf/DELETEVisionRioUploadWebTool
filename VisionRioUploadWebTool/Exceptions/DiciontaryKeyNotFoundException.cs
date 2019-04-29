using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Rio.UploadDesktopTool.Exceptions
{
    class DictionaryKeyNotFoundException : Exception
    {
        public DictionaryKeyNotFoundException()
        {

        }

        public DictionaryKeyNotFoundException(string message) 
            : base (message)
        { 

        }

        public DictionaryKeyNotFoundException(string message, Exception inner)
            : base(message, inner)
        {

        }

        public static DictionaryKeyNotFoundException SetMessageItems(string key, string reason)
        {
            string messageTemplate = "The following key cannot be found '{0}'. Source: {1}";
            throw new DictionaryKeyNotFoundException(String.Format(messageTemplate, key, reason));
        }
    }
}
