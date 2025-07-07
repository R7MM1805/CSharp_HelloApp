namespace HelloApp._01_Bases
{
    partial class Program
    {
        /*
         * Realice un programa que calcule el salario mensual de un trabajador
         * Se debe pedir el nombre, horas trabajadas y tarifa por hora.
         * El programa debe calcular el sueldo y mostrar los datos en consola.
         */
        public static void SalaryCalculator()
        {
            WriteLine("Ingrese su nombre");
            string? name = ReadLine();
            WriteLine("Ingrese las horas trabajadas");
            string? hours = ReadLine();
            WriteLine("Ingrese su tarifa por hora");
            string? salaryPerHour = ReadLine();
            string validation = ValidateInputs(name, hours, salaryPerHour);
            string response = string.IsNullOrEmpty(validation) ? CalculateSalary(name!, int.Parse(hours!), decimal.Parse(salaryPerHour!)) : $"Error: {validation}";  
            WriteLine(response);
        }
        private static string ValidateInputs(string? name, string? hours, string? salaryPerHour)
        {
            string response = string.IsNullOrWhiteSpace(name) ? "Se requiere el nombre" : string.Empty;
            response = string.IsNullOrEmpty(response) ? ValidateInt(hours) : response;
            return string.IsNullOrEmpty(response) ? ValidateDecimal(salaryPerHour) : response;
        }
        private static string ValidateInt(string? hours) => int.TryParse(hours, out _) ? string.Empty : "Las horas ingresadas deben ser un número entero";
        private static string ValidateDecimal(string? salaryPerHour) => decimal.TryParse(salaryPerHour, out _) ? string.Empty : "El salario por hora debe ser un decimal";
        private static string CalculateSalary(string name, int hours, decimal salaryPerHour)
        {
            decimal totalSalary = hours * salaryPerHour;
            return $"""
                Calculadora de Salarios

                Nombres: {name}
                Horas trabajadas: {hours}
                Sueldo por hora: {salaryPerHour:C}
                Sueldo total: {totalSalary:C}
                """;
        }
    }
}