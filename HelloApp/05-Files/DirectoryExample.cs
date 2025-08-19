partial class Program
{
    public static void DirectoryExample()
    {
        string directoryPath = "../../../05-Files/";
        string newDirectory = $"{directoryPath}DirEjemplo";
        Directory.CreateDirectory(newDirectory);
        if (Directory.Exists(newDirectory)) WriteLine("El directorio existe");
        WriteLine("\nEliminando directorio");
        Directory.Delete(newDirectory, true);
    }
}