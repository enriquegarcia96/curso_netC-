partial class Program
{

    static void Generics()
    {

        string[] names = { "Juan", "Luis", "Diana" };
        int[] numbers = { 1, 2, 3, 25 };

        WriteLine($"Tamaño del arreglo numerico {GetArrayLength(numbers)}");

        WriteLine($"Tamaño del arreglo nombres {GetArrayLength(names)}");

        Box<int> numberBox = new Box<int> { Content = 50 };
        Box<string> stringBox = new Box<string> { Content = "Ahora soy Texto" };
        numberBox.Show();
        stringBox.Show();
    }



    // Metodo Generico
    static int GetArrayLength<T>(T[] array)
    {
        return array.Length;
    }
}


class Box<T>
{
    public T? Content { get; set; }

    public void Show()
    {
        WriteLine($"Contenido: {Content}");
    }
}