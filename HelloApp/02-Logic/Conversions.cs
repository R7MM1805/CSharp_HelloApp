partial class Program
{
    public static void Conversions()
    {
        int number = 42;
        double decimalNumber = number;
        WriteLine(decimalNumber);

        double explicitDecimalNumber = 42.5;
        int integerNumber = (int)explicitDecimalNumber;
        WriteLine(integerNumber);

        string text = "123";
        int parsedNumber = int.Parse(text);
        WriteLine(parsedNumber);

        double anotherDecimalNumber = 50.8;
        int convertedNumber = Convert.ToInt32(anotherDecimalNumber);
        WriteLine(convertedNumber);
        int castedNumber = (int)anotherDecimalNumber;
        WriteLine(castedNumber);
    }
}