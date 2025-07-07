partial class Program
{
    public static void NumericTypes()
    {
        int integer = 42;
        double doubleNumber = 3.1416d;
        float floatNumber = 274f;
        long longNumber = 300_200_100L;
        decimal monetaryNumber = 99.99m; //Más preciso
        WriteLine($"Integer:{integer}");
        WriteLine($"Double:{doubleNumber}");
        WriteLine($"Float:{floatNumber}");
        WriteLine($"Long:{longNumber}");
        WriteLine($"Decimal:{monetaryNumber}");
    }
}