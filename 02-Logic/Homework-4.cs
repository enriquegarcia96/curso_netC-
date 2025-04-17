using System.Runtime.InteropServices;

partial class Program{

    static void PrintMultiplicationTable(int number, int tableLimit=10){

        WriteLine($"La tabla de multiplicar del numero {number} desde el 1 hasta el {tableLimit}\n");

        for (int i = 1; i <= tableLimit; i++)
        {
            WriteLine($"{number} x {i}= {number * i}");
        }
        WriteLine();

    }

    static void PrintFactorialTable(int number=5)
    {
        WriteLine($"Factorial del numero {number} desde 1 hasta el {number}\n");

        for (int i = 1; i <= number; i++)
        {
            WriteLine($"{i}! = {Factorial(i)}");
        }
        WriteLine();
    }

    static int Factorial(int number)
    {
        int result = 1;

        for (int i = 1; i <= number; i++)
        {
            result *= i;   
        }
        return result;

    }

}