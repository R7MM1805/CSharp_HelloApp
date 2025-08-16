partial class Program
{
    public static void SalesAnalysis()
    {
        List<Sale> sales =
        [
            new("Laptop", "Electrónica", 1500),
            new("Teléfono", "Electrónica", 900),
            new("Silla", "Muebles", 1200),
            new("Escritorio", "Muebles", 800),
            new("Tablet", "Electrónica", 1300),
            new("Lámpara", "Iluminación", 400)
        ];
        ShowSales(sales, 1000m);
        WriteLine("\n");
        ShowSalesPerCategory(sales);
    }
    class Sale(string product, string category, decimal amount)
    {
        public string Product { get; set; } = product;
        public string Category { get; set; } = category;
        public decimal Amount { get; set; } = amount;
        public void ShowInformation() => WriteLine($"Producto: {Product}, Categoría: {Category}, Monto: {Amount:C}");
    }
    private static void ShowSales(List<Sale> sales, decimal amount)
    {
        if (ValidateSales(sales))
        {
            WriteLine($"Ventas con montos mayor a {amount:C}");
            sales = [.. sales.Where(x => x.Amount > amount)];
            sales.ForEach(x => x.ShowInformation());
        }
    }
    private static bool ValidateSales(List<Sale> sales)
    {
        if (sales is not null && sales.Count > 0) return true;
        WriteLine("No hay ventas registradas");
        return false;
    }
    private static void ShowSalesPerCategory(List<Sale> sales)
    {
        if (ValidateSales(sales))
        {
            IEnumerable<IGrouping<string, Sale>> groupSales = sales.GroupBy(x => x.Category);
            foreach (IGrouping<string, Sale> group in groupSales)
            {
                WriteLine($"Categoría: {group.Key}, Total Ventas: {CalculateSales([.. group]):C}");
            }
        }
    }
    private static decimal CalculateSales(List<Sale> sales) => sales.Sum(x => x.Amount);
}