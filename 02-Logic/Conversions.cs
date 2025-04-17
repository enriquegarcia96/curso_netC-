partial class Program
{
    static void Conversions()
    {

        int number = 42;
        double decimalNumber = number;
        WriteLine(decimalNumber);



        double explicitDecimalNumber = 42.5;
        int integerNumber = (int)explicitDecimalNumber;
        WriteLine(integerNumber);


        //convert o parse
        string text = "123";
        int parsedNumber = int.Parse(text);
        WriteLine(parsedNumber);

        //convert
        double anotherDecimalNumber = 50.6;
        int convertedNumber = Convert.ToInt32(anotherDecimalNumber);
        WriteLine($"redonderar? {convertedNumber}"); // redonderar
        int castedNumber = (int) anotherDecimalNumber;
        WriteLine(castedNumber); // truncar

    }
}