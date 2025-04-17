namespace HelloApp._01_Bases
{
    partial class Program
    {
        public static void NumericTypes()
        {
            int integer = 42;
            double doubleNumber = 3.1416d;
            float floatNumber = 274f;
            long longNumber = 300_200_100L;
            decimal monetaryNumber = 99.99m; //Más preciso
            Console.WriteLine($"Integer:{integer}");
            Console.WriteLine($"Double:{doubleNumber}");
            Console.WriteLine($"Float:{floatNumber}");
            Console.WriteLine($"Long:{longNumber}");
            Console.WriteLine($"Decimal:{monetaryNumber}");
        }
    }
}