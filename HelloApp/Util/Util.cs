namespace HelloApp.Util
{
    public class Util
    {
        public static string GenerateID() => Guid.NewGuid().ToString("N")[..7];
        public static void SetMessage(ConsoleColor color, string message)
        {
            ForegroundColor = color;
            WriteLine(message);
            ResetColor();
        }
    }
}
