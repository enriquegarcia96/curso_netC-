partial class Program
{
    static void Conditionals()
    {
        int age = 19;
        if (age >= 18)
        {
            WriteLine("Eres mayor de edad");
        }
        else
        {
            WriteLine("Eres menor de edad");
        }


        string message = age >= 18 ? "Eres mayor de edad" : "Eres menor de edad";

        WriteLine(message);

        int temperature = 30;
        if (temperature > 35)
        {
            WriteLine("Hace mucha calor.");
        }
        else if (temperature >= 20)
        {
            WriteLine("Es agradable.");
        }
        else
        {
            WriteLine("Hace frio");
        }


        //Switch
        int day = 3;
        switch (day)
        {
            case 1:
                WriteLine("Lunes");
                break;

            case 2:
                WriteLine("Martes");
                break;

            case 3:
                WriteLine("Miercoles");
                break;

            default:
                WriteLine("Dia no valido");
                break;
        }

        // Switch con expresiones
        string dayMessage = day switch
        {
            1 => "Lunes",
            2 => "Martes",
            3 => "Miercoles",
            _ => "Dia no valido"
        };

        WriteLine(dayMessage);

    }
}