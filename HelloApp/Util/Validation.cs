namespace HelloApp.Util
{
    public class Validation
    {
        public static string ValidateString(string? value, string message) => string.IsNullOrWhiteSpace(value) ? message : string.Empty;
    }
}