namespace HelloApp._01_Bases
{
    partial class Program
    {
        /*
         * Mostrar el inventario actualizado después de cada compra.
         * Crear un menu con las opciones de 1. Comprar producto y 2. Salir.
         */

        public static void InventoryManager()
        {
            string[] products = ["Laptop", "Mouse", "Teclado", "Monitor", "Impresora"];
            int[] stock = [10, 25, 15, 8, 5];
            decimal[] prices = [750.50m, 20.50m, 45.00m, 200.99m, 150.00m];
            InitialInventory(products, stock, prices);
        }

        private static void InitialInventory(string[] products, int[] stock, decimal[] prices)
        {
            string responseValidate;
            do
            {
                responseValidate = ValidateOption(ShowOptions());
            }
            while (responseValidate == "Error");
            if (responseValidate == "1")
            {
                ShowOptionOne(products, stock, prices);
            }
            else if (responseValidate == "2")
            {
                WriteLine("Gracias por su visita");
            }
        }
        private static string? ShowOptions()
        {
            WriteLine("1. Comprar productos");
            WriteLine("2. Salir");
            WriteLine("\nIngrese una opción:");
            return ReadLine();
        }
        private static string ValidateOption(string? selectedOption)
        {
            string[] options = ["1", "2"];
            return options.Contains(selectedOption ?? string.Empty) ? selectedOption! : "Error";
        }
        private static void ShowOptionOne(string[] products, int[] stock, decimal[] prices)
        {
            ShowProducts(products, stock, prices);
            WriteLine("\nIngrese el producto que desee comprar");
            string? searchedProduct = ReadLine();
            WriteLine("\nIngrese la cantidad que desee comprar");
            string? quantity = ReadLine();
            (string responseValidate, int productIndex) = ValidateSale(products, stock, searchedProduct, quantity);
            if (string.IsNullOrEmpty(responseValidate))
            {
                SaleProduct(products, stock, prices, productIndex, int.Parse(quantity!));
            }
            else
            {
                WriteLine(responseValidate);
                ShowOptionOne(products, stock, prices);
            }
        }
        private static void ShowProducts(string[] products, int[] stock, decimal[] prices)
        {
            WriteLine("Inventario de productos");
            WriteLine("------------------------");
            for (int i = 0; i < products.Length; i++)
            {
                WriteLine($"Producto: {products[i]} - Stock: {stock[i]} - Precio: {prices[i]:C}");
            }
        }
        private static (string, int) ValidateSale(string[] products, int[] stock, string? searchedProduct, string? quantity)
        {
            int productIndex = GetProductIndex(products, searchedProduct);
            if (productIndex == -1) return ("El producto no se encuentra en el inventario", productIndex);
            string response = ValidateStock(stock, quantity, productIndex);
            return (response, productIndex);
        }
        private static int GetProductIndex(string[] products, string? searchedProduct)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase)) return i;
            }
            return -1;
        }
        private static string ValidateStock(int[] stock, string? quantity, int productIndex)
        {
            bool isNumber = int.TryParse(quantity, out int productQuantity);
            if (!(isNumber && productQuantity > 0)) return "La cantidad ingresada debe ser un número válido mayor a 0";
            return productQuantity > stock[productIndex] ? "La cantidad solicitada sobrepasa el stock" : string.Empty;
        }
        private static void SaleProduct(string[] products, int[] stock, decimal[] prices, int productIndex, int quantity)
        {
            WriteLine($"Compra exitosa. Total a pagar: {decimal.Round(prices[productIndex] * quantity, 2):C}");
            stock[productIndex] = stock[productIndex] - quantity;
            WriteLine($"Stock restante para el producto {products[productIndex]} es: {stock[productIndex]}");
            InitialInventory(products, stock, prices);
        }
    }
}