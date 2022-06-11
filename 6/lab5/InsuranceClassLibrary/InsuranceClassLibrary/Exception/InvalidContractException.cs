using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace InsuranceClassLibrary.Exception
{
    [Serializable]
    public class InvalidContarctException : System.Exception
    {
        public InvalidContarctException()
        {
        }

        public InvalidContarctException(string message) : base(message)
        {
        }

        public InvalidContarctException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidContarctException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
