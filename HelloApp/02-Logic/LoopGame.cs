partial class Program
{
    public static void LoopGame()
    {
        int count = 0;
        WriteLine("Pulse cualquier tecla para aumentar el contador");
        WriteLine("Pulse ESC para salir. \n");
        ConsoleKey key;
        while (true)
        {
            count++;
            key = ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                WriteLine("Saliste del juego. Pulsaste la tecla ESC");
                WriteLine($"Pulsaste {count} veces");
                WriteLine("Programa terminado");
                break;
            }
        }
    }
}