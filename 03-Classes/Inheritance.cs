partial class Program
{
    static void Inheritance()
    {
        HogartsStudent student = new HogartsStudent() { Name = "Enrique", House = "Gryffidor" };
        HogwartsProfessor professor = new HogwartsProfessor() { Name = "Severus Snape", Subject = "Pociones" };

        student.Greet();
        student.ShowHouse();
        professor.Greet();
        professor.MySuject();
    }
}


class Character
{
    public string? Name { get; set; }
    public virtual void Greet()
    {
        WriteLine($"Hola, soy {Name}");
    }


}

class HogartsStudent : Character
{

    public string? House { get; set; }

    public void ShowHouse()
    {
        WriteLine($" Pertenezco a la casa {House} en Howagarts");
    }

    public override void Greet()
    {
        WriteLine($"Hola soy {Name} y soy estudiante");
        //base.Greet();
    }

}



class HogwartsProfessor : Character
{

    public string? Subject { get; set; }

    public void MySuject()
    {
        WriteLine($"Enseno {Subject} en Howgwarts");
    }

    public override void Greet()
    {
        WriteLine($"Hola, soy {Name} y soy profesor");

    }

}