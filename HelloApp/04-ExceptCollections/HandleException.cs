partial class Program
{
    static string? amount;
    public static void HandleException()
    {
		try
		{
            Write("Ingrese un monto");
            amount = ReadLine();
            if (string.IsNullOrWhiteSpace(amount)) return;
            if(decimal.TryParse(amount, out decimal amountValue))
            {
                WriteLine($"El monto que ingresaste es {amountValue:C}");
            }
            else
            {
                WriteLine($"No se pudo convertir el texto {amount} a decimal");
            }
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
        finally
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine("Esto siempre se ejecuta");
        }
    }
}