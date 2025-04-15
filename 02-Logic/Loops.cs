partial class Program
{
    static void Loops()
    {

        //while
        int counter = 1;
        while (counter <= 5)
        {
            //WriteLine($"Iteracion {counter}");
            counter++;
        }

        //do while
        int number = 0;
        do
        {

            //WriteLine($"Numero: {number}");
            number++;
        } while (number < 3);



        for (int i = 0; i < 5; i++)
        {
            WriteLine($"Iteracion: {i}");
        }

        for (int i = 10; i >= 0; i -= 2)
        {
            WriteLine(i);
        }



        //foreach
        string[] fruits = ["Manzana", "Pera", "Piña"];
        foreach (var fruit in fruits)
        {
            WriteLine(fruit);
        }


        //list
        List<string> names = ["Pedro", "kike", "andrea"];
        foreach (var name in names)
        {
            WriteLine(name);
        }

    }
}