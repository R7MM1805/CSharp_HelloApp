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
    }
    private static void ShowNames(List<string> names) => names.ForEach(WriteLine);
}