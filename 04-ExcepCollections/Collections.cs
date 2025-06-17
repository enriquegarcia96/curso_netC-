partial class Program
{

    static void Collections()
    {

        List<string> names = ["Luis", "Pedro", "Pablo"];
        names.Add("Anal");
        //ShowNames(names);
        WriteLine("Despues de remover a luis");
        names.Remove("Luis");
        //ShowNames(names);

        Dictionary<int, string> students = new()
        {
            {1, "Anal"},
            {2, "Carlos"},
            {3, "Pablo"}
        };

        students.Add(4, "KIke");
        foreach (var student in students)
        {
          //  WriteLine($"LLave: {student.Key}, Valor: {student.Value}");
        }

        students.Remove(1);
        //WriteLine("DEspues de remover a Anal");
        //ShowStudent(students);

        HashSet<string> users = ["Luis", "Pedro", "Pablo"];
        users.Add("Meli");
        users.Add("Kike");
        users.Add("Luis");
        foreach (var user in users)
        {
            WriteLine(user);
        }

    }

    private static void ShowStudent(Dictionary<int, string> students)
    {
        foreach (var student in students)
        {
            WriteLine($"LLave: {student.Key}, Valor: {student.Value}");
        }
    }

    private static void ShowNames(List<string> names){
        foreach (var name in names)
        {
            WriteLine(name);
        }
    }

}   