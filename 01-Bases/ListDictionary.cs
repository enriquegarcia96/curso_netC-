partial class Program
{
    static void ListDictionary()
    {

        List<string> names = new List<string> { "Kike", "Doris", "Derick" };
        names.Add("Maria");

        Console.WriteLine($"Total de nombres: {names.Count}");

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        names.Remove("Kike");
        bool isPresent = names.Contains("Kike");
        Console.WriteLine($"¿Kike esta en la lista? {isPresent}");



        //Dictionary
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            {1, "Ana"},
            {2, "Doris"},
            {3, "Felipe"}
        };

        Console.WriteLine($"Estudiante por la llave {students[2]}");

        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Nombre: {student.Value}");
        }




    }
}