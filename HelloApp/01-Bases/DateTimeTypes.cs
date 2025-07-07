namespace HelloApp._01_Bases
{
    partial class Program
    {
        public static void DateTimeTypes()
        {
            DateTime now = DateTime.Now;
            DateTime today = DateTime.Today;
            DateTime nowWeekAgo = now.AddDays(-7);
            DateTime customDate = new(1994, 11, 2);
            DayOfWeek dayOfWeek = now.DayOfWeek;

            WriteLine($"""
                Fecha Actual: {now},
                Hoy: {today},
                Hace una semana: {nowWeekAgo:dd/MM/yyyy},
                Fecha personalizada: {customDate},
                Día de la semana: {dayOfWeek}
                """);
        }
    }
}