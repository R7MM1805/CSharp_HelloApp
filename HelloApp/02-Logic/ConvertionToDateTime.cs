using System.Globalization;

partial class Program
{
    public static void ConvertionToDateTime()
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-PE");

        int friends = int.Parse("101");
        double entryCost = 25.50;
        DateTime birthDate = DateTime.Parse("2 Marzo 2025");
        WriteLine($"Tengo {friends} amigos para invitar a mi fiesta");
        WriteLine($"La celebración de mi cumpleaños será: {birthDate}");
        WriteLine($"Formato largo: {birthDate:D}");
        WriteLine($"El costo de la entrada será: {entryCost:C}");
    }
}