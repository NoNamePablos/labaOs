using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace lab4
{
    [Serializable]
    class InvalidEmployeeException : System.Exception
    {
        public InvalidEmployeeException()
        {
        }

        public InvalidEmployeeException(string message) : base(message)
        {
        }

        public InvalidEmployeeException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidEmployeeException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
