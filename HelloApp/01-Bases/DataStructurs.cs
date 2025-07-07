namespace HelloApp._01_Bases
{
    partial class Program
    {
        public static void DataStructurs()
        {
            User ricardo = new() { Name = "Ricardo", Age = 30 };
            ricardo.Greet();
            Point point = new() { X = 30, Y = 20 };
            WriteLine($"Punto: {point.X}, {point.Y}");
            CellPhone phoneNokia = new("Nokia", 2020);
            WriteLine($"Modelo: {phoneNokia.Model} - Lanzamiento: {phoneNokia.Year}");
        }
    }

    public class User
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public void Greet()
        {
            WriteLine($"Hola soy el usuario: {Name} y tengo {Age} años");
        }
    }

    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    record CellPhone(string Model, int Year);
}
