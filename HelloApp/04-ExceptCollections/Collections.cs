partial class Program
{
    public static void Collections()
    {
        List<string> names = ["Ricardo", "Rosa", "Álvaro"];
        names.Add("Martin");
        ShowNames(names);
        names.Remove("Rosa");
        WriteLine("Despues de remover");
        ShowNames(names);
        Dictionary<int, string> students = new()
        {
            { 1, "Ricardo" },
            { 2, "Rosa" },
            { 3, "Álvaro" },
        };
        WriteLine("Diccionario");
        ShowStudents(students);
        students.Add(4, "Maria");
        WriteLine("Añadir datos a diccionario");
        ShowStudents(students);
        students.Remove(3);
        WriteLine("Quitar datos a diccionario");
        ShowStudents(students);
        HashSet<string> uniqueNames = ["Álvaro", "Rosa", "Fabrizzio", "Maria"];
        WriteLine("HashSet");
        ShowUniqueNames(uniqueNames);
        uniqueNames.Add("Ricardo");
        uniqueNames.Add("Fabrizzio");
        uniqueNames.Add("Martin");
        uniqueNames.Add("Maria");
        WriteLine("Añadir datos a HashSet");
        ShowUniqueNames(uniqueNames);
        uniqueNames.Remove("Fabrizzio");
        WriteLine("Quitar datos a HashSet");
        ShowUniqueNames(uniqueNames);
    }
    private static void ShowNames(List<string> names) => names.ForEach(WriteLine);
    private static void ShowStudents(Dictionary<int, string> valuePairs)
    {
        foreach (KeyValuePair<int, string> student in valuePairs)
        {
            WriteLine($"Llave: {student.Key} - Valor: {student.Value}");
        }
    }
    private static void ShowUniqueNames(HashSet<string> uniques)
    {
        foreach (string unique in uniques)
        {
            WriteLine(unique);
        }
    }
}