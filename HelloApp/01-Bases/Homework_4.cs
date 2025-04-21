using System.Globalization;

namespace HelloApp._01_Bases
{
    partial class Program
    {
        /*
         * Pedir al usuario su fecha de nacimiento y calcular cuántos días faltan para su próximo cumpleaños.
         * Consideraciones:
         * La fecha de nacimiento ingresada debe ser interpretada correctamente, 
         * asegurando que las comparaciones de fechas no sean afectadas por las horas.
         * Investigar acerca de `CultureInfo.InvariantCulture` para que no afecte la configuración regional del sistema.
         * Se debe manejar el caso en que el cumpleaños ya haya pasado en el año actual, 
         * sumando un año para calcular la fecha del próximo (opcional).
         */

        public static void DaysUntilNextBirthday()
        {
            Console.WriteLine("Ingrese su nombre:");
            string? name = Console.ReadLine();
            Console.WriteLine("Ingrese su fecha de nacimiento (dd/MM/yyyy):");
            string? birthDate = Console.ReadLine();
            string validation = ValidateInputs(name, birthDate);
            string response = string.IsNullOrEmpty(validation) ? CalculateDaysUntilNextBirthDate(name!, birthDate!) : $"Error: {validation}";
            Console.WriteLine(response);
        }

        private static string ValidateInputs(string? name, string? birthDate)
        {
            string response = string.IsNullOrWhiteSpace(name) ? "Se requiere el nombre" : string.Empty;
            return string.IsNullOrEmpty(response) ? ValidateDate(birthDate) : response;
        }
        private static string ValidateDate(string? birthDate)
        {
            string response = string.IsNullOrWhiteSpace(birthDate) ? "Se requiere la fecha de nacimiento" : string.Empty;
            return string.IsNullOrEmpty(response) ? ValidateBirthDate(birthDate!) : response;
        }
        private static string ValidateBirthDate(string birthDate) => DateTime.TryParseExact(birthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _) ? string.Empty : "La fecha ingresada no tiene el formato requerido";
        private static string CalculateDaysUntilNextBirthDate(string name, string date)
        {
            DateTime birthDate = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime currentDate = DateTime.Now.Date;
            DateTime customDate = new(currentDate.Year, birthDate.Month, birthDate.Day);
            customDate = customDate.Date > currentDate ? customDate : new(currentDate.Year + 1, birthDate.Month, birthDate.Day);
            TimeSpan timeSpan = customDate.Date - currentDate;
            return $"""
                {name}, faltan {timeSpan.Days} días para tu cumpleaños 
                """;
        }
    }
}