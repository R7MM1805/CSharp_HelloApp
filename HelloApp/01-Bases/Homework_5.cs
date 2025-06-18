namespace HelloApp._01_Bases
{
    partial class Program
    {
        /*
         * El sistema debe manejar 3 listas (Productos - Stock - Precio)
         * El usuario debe seleccionar el producto que desea comprar
         * El usuario ingresa la cantidad solicitada
         * El sistema valida el stock del producto y muestra el precio al usuario
         * El usuario ingresa el monto a pagar y el sistema valida que sea el monto solicitado.
         * El sistema debe descontar el stock del producto.
         * El sistema debe validar todas las interacciones del usuario y mostrar los mensajes correspondientes
         */

        public static void InventoryManager()
        {
            string[] products = ["Monitor", "Mouse", "Teclado"];
            int[] stock = [10, 25, 30];
            decimal[] prices = [100.50m, 20.50m, 45.00m];
            Console.WriteLine("Inventario de productos");
            Console.WriteLine("------------------------");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Producto: {products[i]} - Stock: {stock[i]} - Precio: {prices[i]}");
            }
            Console.WriteLine("\nIngrese el producto que desee comprar");
            string? searchedProduct = Console.ReadLine();
            Console.WriteLine("\nIngrese la cantidad que desee comprar");
            string? quantity = Console.ReadLine();
            string validation = ValidateInputs(products, stock, prices, searchedProduct, quantity);
            Console.WriteLine(validation);
        }

        private static string ValidateInputs(string[] products, int[] stock, decimal[] prices, string? product, string? quantity)
        {
            if (products is null || products.Length == 0) return "No existen productos en el inventario";
            if (stock is null || stock.Length == 0) return "No existen stock de productos";
            if (products.Length != stock.Length) return "La cantidad de productos no coincide con la cantidad de stock";
            if (string.IsNullOrEmpty(product)) return "Se requiere ingresar el producto a adquirir";
            if (!products.Any(x => x.Equals(product, StringComparison.OrdinalIgnoreCase))) return $"El producto ingresado '{product}' no se encuentra en el inventario";
            if (string.IsNullOrEmpty(quantity)) return "Se requiere la cantidad de productos";
            bool isNumber = int.TryParse(quantity, out int productQuantity);
            if (!isNumber) return "La cantidad ingresada debe ser un número";
            if (productQuantity <= 0) return "La cantidad ingresada debe ser mayor o igual a 1";
            string message = string.Empty;
            for (int i = 0;i < products.Length; i++)
            {
                if (products[i].Equals(product, StringComparison.OrdinalIgnoreCase))
                {
                    message = (productQuantity > stock[i]) ? "La cantidad solicitada sobrepasa el stock del producto" : "";
                    if (!string.IsNullOrEmpty(message)) break;
                    message = $"Compra exitosa del producto. Monto total {prices[i] * productQuantity}";
                }
            }
            return message;
        }
    }
}