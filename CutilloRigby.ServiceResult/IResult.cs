namespace CutilloRigby.ServiceResult;

public interface IResult<TSuccess, TFailure>
{
    TSuccess? SuccessResult { get; }
    TFailure? FailureResult { get; }
    bool Successful { get; }
}
