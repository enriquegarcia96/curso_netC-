partial class Program
{
    static void DataStructures()
    {

        User pedro = new User { Name = "Pedro", Age = 33 };
        pedro.Greet();

        Point punto = new Point { X = 30, Y = 20 };
        Console.WriteLine($"Punto ({punto.X}, {punto.Y})");

        CellPhone iphone = new CellPhone("Iphone", 2010);
        Console.WriteLine(iphone);
    }
}



// Para objetos que son mas complejos, para eso se usa la clase.
class User
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public void Greet()
    {
        Console.WriteLine($"Hola, soy el usuario {Name} y tengo una edad de {Age}");
    }
}




// Para datos que son mas ligeros se usa el struct.
struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}


// el record para datos inmutables se usa el record.
record CellPhone(string Model, int Year);
