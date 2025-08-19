using System.Text;

partial class Program
{
    public static void FileExample()
    {
        string filePath = "../../../05-Files/Ejemplo.txt";
        string text = File.ReadAllText(filePath, Encoding.Latin1);
        string[] lines = File.ReadAllLines(filePath, Encoding.Latin1);
        WriteLine(text);
        WriteLine("\nEn arreglo de string");
        foreach (string line in lines)
        {
            WriteLine(line);
        }
        WriteLine("\nGenerando copia");
        File.Copy(filePath, "../../../05-Files/EjemploCopia.txt", true);
        WriteLine("\nEliminando archivo");
        File.Delete("../../../05-Files/EjemploCopia.txt");
    }
}