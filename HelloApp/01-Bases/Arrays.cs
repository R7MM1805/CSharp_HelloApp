namespace HelloApp._01_Bases
{
    partial class Program
    {
        public static void Arrays()
        {
            /*Formas de inicializar arreglos*/

            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            int[] numbersArray = [1, 2, 3, 4, 5];

            /*Acceder a los datos del arreglo a traves de índices*/
            Console.WriteLine($"Primer elemento: {numbersArray[0]}");
            Console.WriteLine($"Tercer elemento: {numbersArray[2]}");
            Console.WriteLine($"Cantidad de elementos: {numbersArray.Length}");
        }
    }
}