partial class Program
{
    public static void StringTypes()
    {
        string name = "Ricardo";
        string message = "Hola " + name;
        string interpolatedMessage = $"Hola {name}";
        WriteLine(message);
        WriteLine(interpolatedMessage);
        WriteLine($"Tu nombre tiene {name.Length} caracteres");
        WriteLine($"Tu nombre en mayusculas es {name.ToUpper()}");
        WriteLine($"Tu nombre en minuscula es {name.ToLower()}");
        int number = 30;
        WriteLine(number.ToString());
        bool isStudent = true;
        WriteLine(isStudent.ToString());
    }
}