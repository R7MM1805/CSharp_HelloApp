partial class Program
{
    static string? amount;
    public static void HandleException()
    {
        int number = 10;
		try
		{
            Write("Ingrese un monto");
            amount = ReadLine();
            if (string.IsNullOrWhiteSpace(amount)) return;
            decimal amountValue = decimal.Parse(amount);
            WriteLine($"El monto que ingresaste es {amount:C}");
        }
		catch (DivideByZeroException)
		{
            ForegroundColor = ConsoleColor.Red;
            WriteLine("La división entre 0 no es válida");
		}
        catch (FormatException) when (amount?.Contains('$') == true)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine("No es necesario ingresar $");
        }
        catch (Exception e)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine(e.Message);
        }
    }
}