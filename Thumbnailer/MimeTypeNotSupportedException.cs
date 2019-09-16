using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Thumbnailer
{


    [Serializable]
    public sealed class MimeTypeNotSupportedException : Exception
    {
        public MimeTypeNotSupportedException() { }
        public MimeTypeNotSupportedException(string message) : base(message) { }
        public MimeTypeNotSupportedException(string message, Exception inner) : base(message, inner) { }
        private MimeTypeNotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
