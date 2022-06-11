using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace lab4
{
    [Serializable]
    public class InvalidWorksException : System.Exception
    {
        public InvalidWorksException()
        {
        }

        public InvalidWorksException(string message) : base(message)
        {
        }

        public InvalidWorksException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidWorksException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
