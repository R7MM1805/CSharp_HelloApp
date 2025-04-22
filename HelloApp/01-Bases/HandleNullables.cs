namespace HelloApp._01_Bases
{
    partial class Program
    {
        public static void HandleNullables()
        {
            string name = "Ricardo";
            string? lastName = null;
            Console.WriteLine($"Name: {name} - LastName: {lastName ?? "No proporcionado"}");
            string? text = null;
            Console.WriteLine(text?.Length);
            Console.WriteLine("Continua el proceso");
        }
    }
}