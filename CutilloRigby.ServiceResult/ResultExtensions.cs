using System;

namespace CutilloRigby.ServiceResult;
public static class ResultExtensions
{
    public static void Switch<TSuccess, TFailure>(this IResult<TSuccess, TFailure> result, Action<TSuccess?> successAction, Action<TFailure?> failureAction)
    {
        if (result.Successful)
            successAction(result.SuccessResult);
        else
            failureAction(result.FailureResult);
    }

    public static TResult Match<TSuccess, TFailure, TResult>(this IResult<TSuccess, TFailure> result, Func<TSuccess?, TResult> successFunc, Func<TFailure?, TResult> failureFunc)
    {
        if (result.Successful)
            return successFunc(result.SuccessResult);
        return failureFunc(result.FailureResult);
    }
}
