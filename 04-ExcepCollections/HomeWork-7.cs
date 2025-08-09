partial class Program
{
    class Sale

    {
        public string? Product { get; set; }
        public string? Category { get; set; }
        public double Amount { get; set; }

        public Sale(string product, string category, double amount)
        {
            Product = product;
            Category = category;
            Amount = amount;
        }
    }
    static void SalesAnalysis()
    {
        List<Sale> sales = new List<Sale> {
            new Sale("Laptop", "Electrónica", 1500),
            new Sale("Teléfono", "Electrónica", 900),
            new Sale("Silla", "Muebles", 1200),
            new Sale("Escritorio", "Muebles", 800),
            new Sale("Tablet", "Electrónica", 1300),
            new Sale("Lámpara", "Iluminación", 400)
        };

        var ventasSuperiores = from s in sales
                               where s.Amount > 1000
                               select new { s.Category, s.Amount };

        WriteLine("1. Filtrar y mostrar las ventas con monto superior a 1000.");
        foreach (var sale in ventasSuperiores)
        {
            WriteLine($"{sale.Category} - {sale.Amount}");
        }

        var agrupacionVentas = sales.GroupBy(v => v.Category).Select(g => new { Category = g.Key, TotalAmount= g.Sum(s => s.Amount) });
    
        WriteLine("2. Agrupar las ventas por categoría y calcular el total de ventas por categoría.");
        foreach (var venta in agrupacionVentas)
        {
            WriteLine($"Categoria: {venta.Category}, Total ventas: {venta.TotalAmount:C}");
        }

    }
}
