partial class Program
{
    static void SalesReport()
    {

        string product = "Laptop";
        int quantitySold = 3;
        double unitPrice = 750.99;
        double totalAmount = quantitySold * unitPrice;

        Console.WriteLine($"Producto: {product}");
        Console.WriteLine($"Cantidad vendida: {quantitySold}");
        Console.WriteLine($"Total generado: {totalAmount:C}");
    }

    static void SalaryCalculator()
    {

        Console.WriteLine($"Ingrese su nombre:");
        string? employeeName = Console.ReadLine();
        Console.WriteLine();

        Console.Write($"Ingrese su numero de horas trabajadas:");
        double horasTrabajadas = double.Parse(Console.ReadLine()!);
        Console.WriteLine();

        Console.Write($"Ingrese su salario por hora:");
        double tarifaPorHora = double.Parse(Console.ReadLine()!);
        double salary = horasTrabajadas * tarifaPorHora;

        Console.WriteLine($"El salario para {employeeName} es de => {salary:C}");

    }
}