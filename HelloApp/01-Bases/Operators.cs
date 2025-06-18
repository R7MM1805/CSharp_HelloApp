namespace HelloApp._01_Bases
{
    partial class Program
    {
        public static void Operators()
        {
            int number = 22;
            bool isEven = number % 2 == 0;
            bool isGreaterThanTen = number > 10;
            string message = (isEven, isGreaterThanTen) switch
            {
                (true, true) => $"El número '{number}' es par y mayor que 10",
                (false, true) => $"El número '{number}' es impar y mayor que 10",
                _ => $"El número '{number}' no cumple con las condiciones"
            };
            Console.WriteLine(message);
            string ageMessage = (number > 18) ? "Es mayor de edad" : "Es menor de edad";
            Console.WriteLine(ageMessage);
        }
    }
}