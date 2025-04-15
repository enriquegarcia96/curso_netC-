using System.Globalization;

partial class Program
{

    static void DaysOfLife()
    {

        DateTime birthDate = new DateTime(2000, 11, 24);
        TimeSpan difference = DateTime.Now - birthDate;
        Console.WriteLine($"Tu fecha de nacimiento es: {birthDate.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Has vivivo {difference.Days} dias.");
    }


    static void DaysUntilNextBirthday()
    {
        Console.WriteLine($"Introduce tu fecha de nacimiento (dd/mm/aaaa)");
        string dateInput = Console.ReadLine()!;

        //DateTime getBirth = DateTime.Parse(Console.ReadLine()!);

        //Console.WriteLine($"AQUIII {getBirth}");

        CultureInfo incv = CultureInfo.InvariantCulture;
        DateTime birthDate = DateTime.ParseExact(dateInput,"dd/MM/yyyy", incv);

        DateTime currentDate = DateTime.Now.Date;
        DateTime nextbirthday = new DateTime(currentDate.Year, birthDate.Month, birthDate.Day);

        if (nextbirthday < currentDate)
        {
            nextbirthday = nextbirthday.AddYears(1);
        }

        int dayRemaining = (nextbirthday - currentDate).Days;
        Console.WriteLine($"Faltan {dayRemaining} dias para tu proximo cumpleaños.");

    }

}