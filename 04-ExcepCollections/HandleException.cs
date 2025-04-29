partial class Program
{
    static string? amount;

    static void HandleException()
    {

        try
        {
            //int number = 10;
            //int result = number / 0;

            Write("Ingrese un monto: ");
            amount = ReadLine();

            if (string.IsNullOrEmpty(amount))
            {
                return;
            }

            if (double.TryParse(amount, out double amountValue))
            {
                WriteLine($"El monto que introdujiste es el siguiente: {amountValue:C}");
            }
            else
            {
                WriteLine($"No se pudo convertir el texto a numero");
            }

            ValidateAge(16);

        }
        catch (DivideByZeroException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Error: Division por cero");
        }
        catch (FormatException) when (amount?.Contains('$') == true)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine($"No es necesario usar '$'");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine(ex.Message);
        }finally{
            Console.ForegroundColor = ConsoleColor.Green;
            WriteLine("Esto siempre se ejecutara...");
        }
    }

    static void ValidateAge(int age){
        if(age < 18){
            throw new ArgumentException("La edad debe ser mayor a 18");
        }

    }
}