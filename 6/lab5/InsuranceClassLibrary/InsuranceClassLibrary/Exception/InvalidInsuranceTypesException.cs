using System;
using System.Runtime.Serialization;

namespace InsuranceClassLibrary.Exception
{
 
    [Serializable]
    public class InvalidInsuranceTypesException : System.Exception
{
    public InvalidInsuranceTypesException()
    {
    }

    public InvalidInsuranceTypesException(string message) : base(message)
    {
    }

    public InvalidInsuranceTypesException(string message, System.Exception inner) : base(message, inner)
    {
    }

    protected InvalidInsuranceTypesException(
        SerializationInfo info,
        StreamingContext context) : base(info, context)
    {
    }
}
}
