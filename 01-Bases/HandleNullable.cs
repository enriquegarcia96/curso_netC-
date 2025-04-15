partial class Program
{

    static void HandleNullables()
    {

        // NO nulificable
        string firstName = "Enrique";

        //nulificable
        string? lastName = null;
        Console.WriteLine($"Nombre: {firstName}");

        if (lastName != null)
        {
            Console.WriteLine($"Apellido: {lastName}");
        }
        else
        {
            Console.WriteLine($"Apellido NO especificado");
        }

        // Operador de Coalescencia nula ??
        Console.WriteLine($"Apellido: {lastName ?? "Apellido no espeficado!"}");



        // Operador de accedo nulo  seguro => ?.
        string? text = null;
        Console.WriteLine(text?.Length);
        Console.WriteLine("Sigue ejecutando");


    }



}