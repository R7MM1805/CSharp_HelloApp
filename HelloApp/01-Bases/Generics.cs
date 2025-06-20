namespace HelloApp._01_Bases
{
    partial class Program
    {
        public static void Generics()
        {
            string[] names = ["Ricardo", "Rosa", "Alvaro"];
            int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            Console.WriteLine(GetArrayLength(names));
            Console.WriteLine(GetArrayLength(numbers));

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
            Console.WriteLine($"Contenido: {Content}");
        }
    }
}
