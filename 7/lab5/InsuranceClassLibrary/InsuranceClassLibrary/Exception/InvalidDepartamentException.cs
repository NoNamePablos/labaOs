using System;

using System.Runtime.Serialization;


namespace InsuranceClassLibrary.Exception
{

    [Serializable]
    public class InvalidDepartamentException : System.Exception
    {
        public InvalidDepartamentException()
        {
        }

        public InvalidDepartamentException(string message) : base(message)
        {
        }

        public InvalidDepartamentException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidDepartamentException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
