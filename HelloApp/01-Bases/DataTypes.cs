partial class Program
{
    public static void DataTypes()
    {
        int integer = 42;
        double decimalNumber = 3.1416;
        bool isTrue = true;
        char character = 'R';
        string text = "Text from C#";
        DateTime currentDate = DateTime.Now;
        WriteLine($"Integer:{integer} - Decimal:{decimalNumber} - Boolean:{isTrue} - Char:{character} - String:{text} - DateTime:{currentDate}");
    }
}