partial class Program
{

    static void TypeDifference()
    {

        int x = 5;
        int y = x;
        y = 15; // tipos de valor que no cambia

        Console.WriteLine($"x: {x} y: {y}");



        // tipos de valor por referencia, que cambia 
        Person person1 =  new Person { Name = "Enrique"};
        Person person2 = person1;

        person2.Name = "Doris";

        Console.WriteLine($" persona1.Name: {person1.Name}");

    }

}


class Person
{
    public string? Name { get; set; }
}