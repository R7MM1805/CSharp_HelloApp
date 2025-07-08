partial class Program
{
    public static void AnonymusFunction()
    {
        WriteLine(square(15));
        WriteLine(lambdaSquare(5));
        WriteLine();
        List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        List<int> evenNumber = [.. numbers.Where(x => x % 2 == 0)];
        foreach (int even in evenNumber)
        {
            WriteLine(even);
        }
    }
    static Func<int, int> square = delegate (int number)
    {
        return number * number;
    };
    static Func<int, int> lambdaSquare = x => x * x;
}