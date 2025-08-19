partial class Program
{
    public static void WriteFileExample()
    {
        string filePath = "../../../05-Files/EjemploEscritura.txt";
        string content = "Podemos escribir en un archivo";
        StreamWriter sw = new(filePath, true);
        sw.WriteLine(content);
        sw.WriteLine("Nuevo contenido");
        sw.WriteLine($"La hora actual es: {DateTime.Now:HH:mm:ss}");
        sw.Dispose();
        WriteLine("Archivo creado de manera exitosa");
    }
}