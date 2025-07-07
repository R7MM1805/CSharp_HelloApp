partial class Program
{
    public static void Loops()
    {
        #region Bucle While
        int counter = 1;
        while (counter <= 5)
        {
            WriteLine($"Iteración While: {counter}");
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

        #region for
        for (int i = 0; i < 10; i++)
        {
            WriteLine($"Iteración For: {i}");
        }
        for (int i = 10; i >= 0; i -= 2)
        {
            WriteLine($"Personalizar For: {i}");
        }
        #endregion

        #region for-each
        string[] fruits = ["Manzana", "Pera", "Uva", "Piña", "Granadilla"];
        foreach (string fruit in fruits)
        {
            WriteLine($"Fruta Arreglo: {fruit}");
        }
        List<string> names = ["Ricardo", "Rosa", "Alvaro", "Martin", "Rosa", "Fabrizzio"];
        foreach (string name in names)
        {
            WriteLine($"Nombre Lista: {name}");
        }
        #endregion
    }
}