partial class Program
{
    public static void Linq()
    {
        List<int> numbers = [1, 2, 3, 4, 5, 6];
        List<int> evenNumber = [];
        WriteLine("Uso de Tradicional");
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
                evenNumber.Add(number);
        }
        foreach (int number in evenNumber)
        {
            WriteLine(number);
        }
        WriteLine("Uso de LinQ");
        WriteLine("Forma select");
        evenNumber = [.. from num in numbers where num % 2 == 0 select num];
        evenNumber.ForEach(WriteLine);
        WriteLine("Forma Directa");
        evenNumber = [.. numbers.Where(x => x % 2 == 0)];
        evenNumber.ForEach(WriteLine);
    }
}