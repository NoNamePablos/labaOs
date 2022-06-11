using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace lab4
{
    [Serializable]
    public class InvalidTOWException : System.Exception
    {
        public InvalidTOWException()
        {
        }

        public InvalidTOWException(string message) : base(message)
        {
        }

        public InvalidTOWException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidTOWException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
