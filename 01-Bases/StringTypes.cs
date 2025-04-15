using System.Data;

partial class Program
{

    static void showStringTypes()
    {

        string name = "Enrique Garcia";
        string message = "Hola " + name;
        string interpolatedMassage = $"Hola {name}";

        Console.WriteLine(message);
        Console.WriteLine(interpolatedMassage);

        Console.WriteLine($"Tu nombre tiene => {name.Length} Palabras");
        Console.WriteLine($"Tu nombre en mayusculas es => {name.ToUpper()}");
        Console.WriteLine($"Tu nombre en minusculas es => {name.ToLower()}");

        int numero = 29;
        Console.WriteLine($"Cambio => {numero}");
        bool isString = true;
        Console.WriteLine($"Es string? {isString}");


    }
}