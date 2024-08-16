using CutilloRigby.ServiceResult;

for (var i = 0; i < 10; i++)
{
    var getEven = GetEven(i);
    getEven.Switch(
        yes => Console.WriteLine("Success: Number is Even"),
        ex => Console.WriteLine($"Failure: {ex?.Message}")
    );
}

for (var i = 0; i < 10; i++)
{
    var getEvenOfT = GetEvenOfT(i);
    getEvenOfT.Switch(
        number => Console.WriteLine($"Success: {number} is Even"),
        ex => Console.WriteLine($"Failure: {ex?.Message}")
    );
}

Result GetEven(int number)
{
    if (number % 2 == 0)
        return Result.SuccessInstance;
    return new Exception("Number is Odd");
}

Result<int, Exception> GetEvenOfT(int number)
{
    if (number % 2 == 0)
        return number;
    return new Exception($"{number} is Odd");

}