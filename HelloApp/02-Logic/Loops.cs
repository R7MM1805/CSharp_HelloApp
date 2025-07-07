partial class Program
{
    public static void Loops()
    {
        #region Bucle While
        int counter = 1;
        while (counter <= 5)
        {
            WriteLine($"Iteración: {counter}");
            counter++;
        }
        #endregion

        #region do-while
        int number = 0;
        do
        {
            WriteLine($"Número: {number}");
            number++;
        } while (number < 3);
        #endregion
    }
}