partial class Program
{
    public static void Methods()
    {
        Car car = new();
        WriteLine(car.ShowInformation());
        car.Model = "Yaris";
        car.Year = 2022;
        WriteLine(car.ShowInformation());
        Car.ShowMessage();
        Car.ShowMessage("Cambiando de modelo");
        car.ChangeModel("Patrol");
        WriteLine(car.ShowInformation());
        Car.GeneralInformation();
        Car duster = new("Duster", 2018);
        WriteLine(duster.ShowInformation());
        List<Car> cars =
        [
            new Car("Ferrari", 2017),
            new Car("Hyundai", 2020),
            new Car("Toyota", 2024),
        ];
        cars.ForEach(x => WriteLine(x.ShowInformation()));
    }
}
class Car
{
    public string? Model { get; set; }
    public int Year { get; set; }

    public Car(string model, int year)
    {
        Model = model; Year = year;
    }

    public Car() { }

    ~Car() { 
        WriteLine("Destructor llamado. Recurso liberado"); 
    }

    public void ChangeModel(string newModel)
    {
        Model = newModel;
    }
    public string ShowInformation() => $"Automovil: {Model}, Año: {Year}";
    public static void ShowMessage(string message = "Este es un automóvil") => WriteLine(message);
    public static void GeneralInformation() => WriteLine("El automóvil es uno de los transportes más utilizados");
}