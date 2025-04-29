partial class Program
{
    static void AbstracClassExamples()
    {

        HomeAppliance myWasher = new WashigMachine(){Brand="Samdung"};
        HomeAppliance myMicrowave = new Microwave(){Brand="DG"};
        myWasher.ShowBrand();
        myWasher.TurnOn();
        myMicrowave.ShowBrand();
        myMicrowave.TurnOn();

    }
}


abstract class HomeAppliance{

    public string? Brand{get;set;}
    public abstract void TurnOn();

    public void ShowBrand(){
        WriteLine($"La marca del electrodomestico: {Brand}");
    }
}


class WashigMachine : HomeAppliance
{
    public override void TurnOn()
    {
        WriteLine($"La labadora a inicializado el ciclo de lavado");
    }
}

class Microwave : HomeAppliance
{
    public override void TurnOn()
    {
        WriteLine($"🔥 El microondas esta calentando la comida");
    }
}