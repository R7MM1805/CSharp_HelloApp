partial class Program
{
    public static void DayOfLife()
    {
        DateTime birthDate = new(2023, 9, 10);
        DateTime currentDate = DateTime.Now.Date;
        TimeSpan timeSpan = currentDate - birthDate.Date;

        WriteLine($"""
                Has vivido {timeSpan.Days} días
                """);
    }
}