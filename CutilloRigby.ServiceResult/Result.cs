using System;

namespace CutilloRigby.ServiceResult;

public sealed class Result : IResult<object, Exception>
{
    public Result()
    {
        SuccessResult = null;
        FailureResult = default;
        Successful = true;
    }

    public Result(Exception exception)
    {
        SuccessResult = null;
        FailureResult = exception;
        Successful = false;
    }

    public object? SuccessResult { get; }
    public Exception? FailureResult { get; }
    public bool Successful { get; }

    public static readonly Result SuccessInstance = new();

    // Implicit operator for failure
    public static implicit operator Result(Exception ex) => new(ex);
}
