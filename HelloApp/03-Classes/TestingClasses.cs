partial class Program
{
    public static void TestingClasses()
    {
        Vehicle toyota = new("Toyota", "Corolla", 2021);
        toyota.ShowInformation();
        Vehicle honda = new("Honda", "Civic", 2019);
        honda.ShowInformation();
        Vehicle renault = new("Renault", "Duster", 2024);
        renault.ShowInformation();
    }
}
class Vehicle(string brand, string model, int year)
{
    public string Brand { get; set; } = brand;
    public string Model { get; set; } = model;
    public int Year { get; set; } = year;

    public void ShowInformation()
    {
        WriteLine($"Este vehículo es un {Brand} {Model} del año {Year}");
    }
}