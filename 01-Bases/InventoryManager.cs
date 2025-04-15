partial class Program
{
    static void InventoryManager()
    {

        string[] products = ["Laptop", "Monitor", "Mouse", "Teclado", "Impresora"];
        int[] stock = [10, 10, 25, 30, 5];
        double[] prices = [750.50, 250.50, 20.50, 45.50, 150.00];
        int option;

        Console.WriteLine("Software de KIKE");
        Console.WriteLine("----------------\n");

        do
        {
            Console.WriteLine("1. Comprar producto");
            Console.WriteLine("2. Salir\n");

            Console.WriteLine("Ingrese una opción: ");
            option = int.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    Console.WriteLine("Inventario de Productos: \n");
                    Console.WriteLine("---------------------------");

                    for (int i = 0; i < products.Length; i++)
                    {
                        Console.WriteLine($"Producto: {products[i]}, Stock: {stock[i]}, Precio: {prices[i]:C}");
                    }

                    Console.WriteLine("\nIngrese el producto que desea comprar: ");
                    string? searchedProduct = System.Console.ReadLine();
                    Console.WriteLine("Ingrese la cantidad que desea comprar: ");
                    int quantity = int.Parse(Console.ReadLine()!);

                    for (int i = 0; i < products.Length; i++)
                    {

                        if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
                        {
                            if (quantity <= stock[i])
                            {
                                double total = quantity * prices[i];
                                Console.WriteLine($"compra exitosa. El total a pagar: {total:C}\n");
                                Console.WriteLine($"Stock restante para el producto {searchedProduct} es => {stock[i] - quantity}\n");
                                stock[i] = stock[i] - quantity;
                            }
                            else
                            {
                                Console.WriteLine("\nNo hay suficiente stock disponible\n");
                            }
                        }

                    }

                    break;

                case 2:
                    Console.WriteLine("Gracias por su visita!");
                    option = 2;
                    break;

                default:
                    Console.WriteLine("opcion no permitida\n");
                    break;
            }

        } while (option != 2);

    }
}