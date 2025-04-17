partial class Program
{
    static void Tuples()
    {

        (int, string) myTuple = (42, "Hola");
        WriteLine($"Numero: {myTuple.Item1}, Texto: {myTuple.Item2}");

        (int Number, string Text) myOtherTuple = (22, "Hola");
        WriteLine($"Numero: {myOtherTuple.Number}, Texto: {myOtherTuple.Text}");

        var operations = Operations(20, 10);
        WriteLine($"Suma: {operations.Sum}, Resta: {operations.Subtraction}");

        // desectructuracion
        (int sum, int subtraction) = Operations(25, 15);
        WriteLine($"Suma: {sum}, Resta: {subtraction}");

    }

    static (int Sum, int Subtraction) Operations(int a, int b)
    {
        return (a + b, a - b);
    }
}