partial class Program
{
    public static void Properties()
    {
        Animal animal = new("Bosque")
        {
            Species = "Lobo",
            Age = 5
        };
        WriteLine($"Donde vive: {animal.Habitat}, que animal es? {animal.Species}, que tiene categoría tiene {animal.Category}");
    }
}
class Animal(string habitat)
{
    public string Species { get; set; } = "Desconocida";
    public string Category { get; } = "Vertebrado";
    private int age;
    public int Age
    {
        get {  return age; }
        set
        {
            if (value < 0) throw new ArgumentException("La edad no puede ser negativa");
            age = value;
        }
    }
    public string Habitat { get; } = habitat;
}