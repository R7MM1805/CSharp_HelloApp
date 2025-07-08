partial class Program
{
    public static void PrintMultiplicationTable(int number, int tableLimit = 10)
    {
        WriteLine($"La tabla de multiplicar del número {number}. Desde el 1 hasta el {tableLimit}\n");
        for (int i = 1; i <= tableLimit; i++)
        {
            WriteLine($"{number} X {i} = {number * i}");
        }
        WriteLine();
    }

    public static void PrintFactorialTable(int number)
    {
        WriteLine($"Factorial del número {number}. Desde el 1 hasta el {number}\n");
        int resultado = 1;
        for (int i = 1; i <= number; i++)
        {
            resultado *= i;
            WriteLine($"{i}! = {resultado}");
        }
        WriteLine();
    }

    //PrintMultiplicationTable(tableLimit: 84, number: 6);
}