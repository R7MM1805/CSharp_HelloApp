partial class Program
{
    static double CalculateArea(double width, double height) => width * height;
    static string EvaluateNumber(int number)
    {
        if (number > 0) return "Positivo";
        else if (number < 0) return "Negativo";
        else return "Cero";
    }

    public static void Functions()
    {
        double area = CalculateArea(4.5, 2.3);
        WriteLine($"El area total es {area}");
        string evaluate = EvaluateNumber(-45);
        WriteLine($"El número evaluado es: {evaluate}");
    }
}