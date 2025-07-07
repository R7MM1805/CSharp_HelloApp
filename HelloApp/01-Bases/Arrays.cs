
partial class Program
{
    public static void Arrays()
    {
        /*Formas de inicializar arreglos*/
        int[] numbersArray = [1, 2, 3, 4, 5];

        /*Acceder a los datos del arreglo a traves de índices*/
        WriteLine($"Primer elemento: {numbersArray[0]}");
        WriteLine($"Tercer elemento: {numbersArray[2]}");
        WriteLine($"Cantidad de elementos: {numbersArray.Length}");

        /*Acceder al último elemento*/
        WriteLine($"Último elemento: {numbersArray[^1]}");
        WriteLine($"Penúltimo elemento: {numbersArray[^2]}");

        /*Rango para obtener sub-arreglos*/
        int[] firstThree = numbersArray[..3];
        int[] fromIndexTwo = numbersArray[2..];

        WriteLine($"Primeros 3: {firstThree}");
        foreach (int item in firstThree)
        {
            WriteLine(item);
        }
        WriteLine($"Desde el segundo elemento: {fromIndexTwo}");
        foreach (int item in fromIndexTwo)
        {
            WriteLine(item);
        }
    }
}