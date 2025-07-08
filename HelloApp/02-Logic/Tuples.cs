partial class Program
{
    public static void Tuples()
    {
        (int age, string name) = (30, "Ricardo");
        WriteLine(age);
        WriteLine(name);
        (int sum, int sustraction) = Operation(15, 7);
        WriteLine(sum);
        WriteLine(sustraction);
    }

    static (int sum, int sustraction) Operation(int a, int b) => (a + b, a - b);
}