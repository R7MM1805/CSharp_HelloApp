partial class Program
{
    public static void Methods()
    {
        Car car = new()
        {
            Model = "Yaris",
            Year = 2022
        };
        WriteLine(car.ShowInformation());
        Car.ShowMessage();
        Car.ShowMessage("Cambiando de modelo");
        car.ChangeModel("Patrol");
        WriteLine(car.ShowInformation());
        Car.GeneralInformation();
    }
}
class Car
{
    public string? Model { get; set; }
    public int Year { get; set; }

    public void ChangeModel(string newModel)
    {
        Model = newModel;
    }
    public string ShowInformation() => $"Automovil: {Model}, Año: {Year}";
    public static void ShowMessage(string message = "Este es un automóvil") => WriteLine(message);
    public static void GeneralInformation() => WriteLine("El automóvil es uno de los transportes más utilizados");
}