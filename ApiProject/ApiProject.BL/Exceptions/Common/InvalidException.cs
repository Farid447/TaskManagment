using Microsoft.AspNetCore.Http;

namespace ApiProject.BL.Exceptions.Common;

public class InvalidException<T> : Exception, IBaseException
{
    public int Code => StatusCodes.Status400BadRequest;
    public string ErrorMessage { get; }

    public InvalidException() : base(typeof(T).Name + " is invalid")
    {
        ErrorMessage = typeof(T).Name + " is invalid";
    }
    public InvalidException(string msg) : base(msg)
    {
        ErrorMessage = msg;
    }
}
