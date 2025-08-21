namespace TaskMaster
{
    public class Util
    {
        public static string GenerateID() => Guid.NewGuid().ToString("N")[..7];
    }
}