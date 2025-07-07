partial class Program
{
    public static void Generics()
    {
        string[] names = ["Ricardo", "Rosa", "Alvaro"];
        int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        WriteLine(GetArrayLength(names));
        WriteLine(GetArrayLength(numbers));

        Box<int> numberBox = new() { Content = 50 };
        Box<string> stringBox = new() { Content = "Texto" };
        Box<decimal> decimalBox = new() { Content = 10.20m };

        numberBox.Show();
        stringBox.Show();
        decimalBox.Show();
    }

    static int GetIntArrayLength(int[] array) => array.Length;
    static int GetStringArrayLength(string[] array) => array.Length;
    static int GetArrayLength<T>(T[] array) => array.Length;
}

public class Box<T>
{
    public T? Content { get; set; }
    public void Show()
    {
        WriteLine($"Contenido: {Content}");
    }
}