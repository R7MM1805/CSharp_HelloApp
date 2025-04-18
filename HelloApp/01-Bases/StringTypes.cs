namespace HelloApp._01_Bases
{
    partial class Program
    {
        public static void StringTypes()
        {
            string name = "Ricardo";
            string message = "Hola " + name;
            string interpolatedMessage = $"Hola {name}";
            Console.WriteLine(message);
            Console.WriteLine(interpolatedMessage);
            Console.WriteLine($"Tu nombre tiene {name.Length} caracteres");
            Console.WriteLine($"Tu nombre en mayusculas es {name.ToUpper()}");
            Console.WriteLine($"Tu nombre en minuscula es {name.ToLower()}");
            int number = 30;
            Console.WriteLine(number.ToString());
            bool isStudent = true;
            Console.WriteLine(isStudent.ToString());
        }
    }
}