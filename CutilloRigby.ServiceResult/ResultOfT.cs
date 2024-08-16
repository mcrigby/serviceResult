namespace CutilloRigby.ServiceResult;

public sealed class Result<TSuccess, TFailure> : IResult<TSuccess, TFailure>
{
    public Result(TSuccess success)
    {
        SuccessResult = success;
        FailureResult = default;
        Successful = true;
    }

    public Result(TFailure failure)
    {
        SuccessResult = default;
        FailureResult = failure;
        Successful = false;
    }

    public TSuccess? SuccessResult { get; }
    public TFailure? FailureResult { get; }
    public bool Successful { get; }

    // Implicit operator for data
    public static implicit operator Result<TSuccess, TFailure>(TSuccess success) => new(success);

    // Implicit operator for exception
    public static implicit operator Result<TSuccess, TFailure>(TFailure failure) => new(failure);
}
