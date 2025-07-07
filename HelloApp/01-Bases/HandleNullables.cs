partial class Program
{
    public static void HandleNullables()
    {
        string name = "Ricardo";
        string? lastName = null;
        WriteLine($"Name: {name} - LastName: {lastName ?? "No proporcionado"}");
        string? text = null;
        WriteLine(text?.Length);
        WriteLine("Continua el proceso");
    }
}