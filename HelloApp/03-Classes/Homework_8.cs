partial class Program
{
    public static void ProductSaleDemo()
    {
        Inventory inventory = new();
        Product laptop = new("Laptop", 1200.99m, 5);
        Product mouse = new("Mouse", 10m, 10);
        inventory.AddProduct(laptop);
        inventory.AddProduct(mouse);
        inventory.ShowInventory();
        laptop.Sell(2);
        mouse.Sell(1);
        inventory.ShowInventory();
    }
    public static void BusFleet()
    {
        Fleet fleet = new();
        Bus corolla = new("Toyota", "Corolla", 2019, 5500.59m, 10000);
        Bus civic = new("Honda", "Civic", 2018, 3850.00m, 8000);
        Bus fiesta = new("Ford", "Fiesta", 2017, 7962.65m, 7000);
        fleet.AddBus(corolla);
        fleet.AddBus(civic);
        fleet.AddBus(fiesta);
        corolla.ShowInformation();
        civic.ShowInformation();
        fiesta.ShowInformation();
        corolla.Drive(5000);
        civic.Drive(5000);
        fiesta.Drive(5000);
        WriteLine("Después de manejar 5000 km");
        corolla.ShowInformation();
        civic.ShowInformation();
        fiesta.ShowInformation();
    }
    class Product(string name, decimal price, int stock)
    {
        public string Name { get; set; } = name;
        public decimal Price { get; set; } = price;
        public int Stock { get; set; } = stock;
        public void ShowInformation() => WriteLine($"Producto: {Name}, Precio: {Price}, Stock: {Stock}");
        public bool Sell(int quantity)
        {
            if (quantity <= Stock)
            {
                WriteLine($"Venta realizada: {quantity} unidades de {Name}");
                Stock -= quantity;
                return true;
            }
            WriteLine($"Stock insuficiente de {Name}");
            return false;
        }
    }
    class Inventory()
    {
        private readonly List<Product> products = [];
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void ShowInventory()
        {
            WriteLine("Inventario de productos");
            products.ForEach(x => x.ShowInformation());
        }
    }
    class Bus(string brand, string model, int year, decimal price, int totalKilometers)
    {
        public string Brand { get; set; } = brand;
        public string Model { get; set; } = model;
        public int Year { get; set; } = year;
        public decimal Price { get; set; } = price;
        public int TotalKilometers { get; set; } = totalKilometers;
        public void Drive(int kilometers)
        {
            TotalKilometers += kilometers;
        }
        public void ShowInformation() => WriteLine($"Marca: {Brand}, Modelo: {Model}, Año: {Year}, Kilometraje: {TotalKilometers:N0}");
        public void ShowPrice() => WriteLine($"El precio del bus {Brand} {Model} es {Price:C}");
    }
    class Fleet()
    {
        private readonly List<Bus> buses = [];
        public void AddBus(Bus bus)
        {
            buses.Add(bus);
        }
        public void ShowFleet()
        {
            buses.ForEach(x => x.ShowInformation());
        }
    }
}