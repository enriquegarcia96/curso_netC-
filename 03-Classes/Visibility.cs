using System.Data;
using System.Globalization;

partial class Program
{

    static void Visibility()
    {

        Jedi jedi = new Jedi();
        jedi.PowerLevel = 5000;
        jedi.LightSaberColor = "Azul";

        //jedi.UseForce();

        //WriteLine(jedi.PublicField);
        //di.RevealSecret();

        Sith sith = new Sith();
        //sith.ShoProtected();
        sith.PowerLevel = 4000;
        sith.LightSaberColor = "Red";
        sith.UseForce();

    }
}

interface IForceUser
{
    int PowerLevel { get; set; }
    string? LightSaberColor { get; set; }

    void UseForce();
}

class Jedi : IForceUser
{
    public string PublicField = "soy un jedi y mi es poder es conocido";
    private string? PrivateField = "Mis pensamientos mas profundos son privados";
    protected string ProtectedField = "El lado oscuro no debe de conocer mis secretos";

    public int PowerLevel { get; set; }
    public string? LightSaberColor { get; set; }

    public void UseForce()
    {
        WriteLine($"Soy un jedi con un sable de luz {LightSaberColor} y mi nivel de poder es: {PowerLevel}");
    }

    private void Meditate()
    {
        WriteLine($"Estoy en profunda meditacion con la fuerza");
    }

    protected void Train()
    {
        WriteLine("Estoy entrenando para convertirme en el mejor Jedi.");
    }

    public void RevealSecret()
    {
        WriteLine(ProtectedField);
        WriteLine(PrivateField);
        Meditate();
    }

}

class Sith : Jedi, IForceUser
{
    public new void UseForce()
    {
        WriteLine($"Soy un Sith con un sable de luz {LightSaberColor} y mi nivel de poder es: {PowerLevel}");

    }
    public void ShoProtected()
    {
        WriteLine(ProtectedField);
        Train();
    }
}


