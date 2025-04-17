using System.Globalization;

partial class Program
{
    static void ConvertionToDateTime()
    {

        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-HND");

        int friends = int.Parse("101");
        double cost = 25.50;


        DateTime birthday =DateTime.Parse("22 Febrero 2025");
        WriteLine($"Tengo {friends} amigos para invitar a mi fiesta");
        WriteLine($"La celebracion de mi cumpleaños sera {birthday}");
        WriteLine($"Formato largo {birthday:D}");
        WriteLine($"El costo de la entrada sera: {cost:C}");


    }
}