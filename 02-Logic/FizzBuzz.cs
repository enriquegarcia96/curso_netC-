partial class Program
{

    protected static string FIZZ = "Fizz";
    protected static string BUZZ = "Buzz";
    protected static string FIZZBUZZ = "FizzBuzz";

    static void FizzBuzz()
    {
        for (int i = 1; i < 101; i++)
        {

            string message = siuu(i) switch
            {
                "FizzBuzz" => FIZZBUZZ,
                "Fizz" => FIZZ,
                "Buzz" => BUZZ,
                _ => i.ToString()
            };

            WriteLine(message);

        }
    }


    static string siuu(int i)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            return FIZZBUZZ;
        }
        else if (i % 3 == 0)
        {
            return FIZZ;
        }
        else if (i % 5 == 0)
        {
            return BUZZ;
        }
        else
        {
            return "";
        }
    }
}