partial class Program
{
    public static void SalesReport()
    {
        string product = "Laptop";
        int quantitySold = 3;
        decimal unitPrice = 589.51m;
        decimal totalAmount = quantitySold * unitPrice;
        WriteLine($"""
                Producto: {product}
                Cantidad vendida: {quantitySold}
                Total venta: {totalAmount:C}
                """);
    }
}