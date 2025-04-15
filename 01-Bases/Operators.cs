using System.Reflection.Metadata;

partial class Program
{

    static void Operators()
    {


        int number = 12;

        bool isEven = number % 2 == 0;

        bool isGreaterThanTen = number > 10;

        if (isEven && isGreaterThanTen)
        {
            Console.WriteLine($"El numero {number} es par y mayor que 10");
        }
        else if (!isEven && isGreaterThanTen)
        {
            Console.WriteLine($"El numero {number} es impar y es mayor que 10");
        }
        else
        {
            Console.WriteLine($"El numero {number} NO cumple con las condiciones");
        }

        // operador ternario (?:)
        int age = 15;
        string catgory = age > 18 ? "Adulto" : "Menor";
        Console.WriteLine(catgory);


    }


}