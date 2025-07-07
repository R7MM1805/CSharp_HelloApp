partial class Program
{
    public static void Conditional()
    {
        #region If-Else-If
        int age = 19;
        if (age >= 18) WriteLine("Eres mayor de edad");
        else WriteLine("Eres menor de edad");
        string message = age >= 18 ? "Eres mayor de edad" : "Eres menor de edad";
        WriteLine(message);
        int temperature = 30;
        if (temperature > 35) WriteLine("Hace mucho calor");
        else if (temperature >= 20) WriteLine("Es agradable");
        else WriteLine("Hace frio");
        #endregion

        #region Switch
        int day = 3;
        switch (day)
        {
            case 1:
                WriteLine("Lunes");
                break;
            case 2:
                WriteLine("Martes");
                break;
            case 3:
                WriteLine("Miercoles");
                break;
            default:
                WriteLine("Día no válido");
                break;
        }
        string dayMessage = day switch
        {
            1 => "Lunes",
            2 => "Martes",
            3 => "Miercoles",
            _ => "Día no válido"
        };
        WriteLine($"Switch con expresiones: {dayMessage}");
        #endregion
    }
}