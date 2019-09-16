using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    [Serializable]
    public sealed class SortAlgorithmNotSupportedException : Exception
    {
        public SortAlgorithmNotSupportedException() { }
        public SortAlgorithmNotSupportedException(string message) : base(message) { }
        public SortAlgorithmNotSupportedException(string message, Exception inner) : base(message, inner) { }
        private SortAlgorithmNotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
