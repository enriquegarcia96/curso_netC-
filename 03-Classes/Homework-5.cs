partial class Program
{
    static void ProductSalesDemo()
    {
        Inventory inventory = new();
        Product laptop = new Product("Laptop", 1300.99, 5);
        Product mouse = new Product("Mouse", 100, 10);
        inventory.AddProduct(laptop);
        inventory.AddProduct(mouse);
        inventory.ShowInventory();
        laptop.Sell(1000);
        mouse.Sell(2);
        inventory.ShowInventory();
    }

    static void BusFleet()
    {
        Fleet fleet = new();
        Bus bus1 = new Bus("Toyota", "8 puertas", 2018, 200.60, 2000);
        Bus bus2 = new Bus("Mazda", "de mi padre", 1996, 2248.88,5000);
        Bus bus3 = new Bus("Honda", "Tu madre", 1980, 30.78, 3000);
        fleet.AddNewBus(bus1);
        fleet.AddNewBus(bus2);
        fleet.AddNewBus(bus3);
        fleet.ShowListBuses();
        WriteLine();
        WriteLine("Despues de manejar 5000 kilometros");
        bus1.Drive(5000);
        bus2.Drive(5000);
        bus3.Drive(5000);
        fleet.ShowListBuses();

    }

    class Bus
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int? Year { get; set; }
        public double Price { get; set; }
        public int? TotalKilometers { get; set; }

        public Bus(string brand, string model, int year, double price, int totalKilometers)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
            TotalKilometers = totalKilometers;
        }

        public void Drive(int kilometers)
        {
            TotalKilometers += kilometers;
        }

        public double ShowPrice()
        {
            return Price;
        }
    }

    class Fleet
    {
        private List<Bus> buses = new List<Bus>();

        public void AddNewBus(Bus bus)
        {
            buses.Add(bus);
        }

        public void ShowListBuses()
        {
            WriteLine("Inventario de los Buses");
            foreach (var bus in buses)
            {
                WriteLine($"Marca: {bus.Brand}, Modelo: {bus.Model}, Year: {bus.Year}, Kilometraje: {bus.TotalKilometers:N}");
            }
        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public void showInfo()
        {
            WriteLine($"Producto: {Name}, Precio: {Price}, Stock: {Stock}");
        }

        public bool Sell(int quantity)
        {
            if (quantity <= Stock)
            {
                Stock -= quantity;
                WriteLine($"Venta realizada, {quantity} unidades de {Name}");
                return true;
            }

            WriteLine($"Stock insuficiente para {Name}");
            return false;
        }
    }

    class Inventory
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void ShowInventory()
        {
            WriteLine("Inventario de productos");
            foreach (var product in products)
            {
                product.showInfo();
            }
        }
    }


}