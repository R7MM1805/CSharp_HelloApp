partial class Program
{
    public static void PathExample()
    {
        string path = "../../../05-Files/Ejemplo.txt";
        string fileName = Path.GetFileName(path);
        WriteLine($"Nombre del archivo: {fileName}");
        string extension = Path.GetExtension(path);
        WriteLine($"Extensión del archivo: {extension}");
        string? directoryName = Path.GetDirectoryName(path);
        WriteLine($"Nombre del directorio del archivo: {directoryName}");
        string combinedPath = Path.Combine("C:", "User", "Documents", "Ejemplo.txt");
        WriteLine($"Ruta armada de ejemplo: {combinedPath}");
        string fullFilePath = Path.GetFullPath(path);
        WriteLine($"Ruta completa del archivo: {fullFilePath}");
    }
}