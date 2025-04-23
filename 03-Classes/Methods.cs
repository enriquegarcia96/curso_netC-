using System.Runtime.CompilerServices;

partial class Program
{
    static void Methods()
    {

        Car car = new Car();
        car.Model = "YAris";
        car.Year = 2022;
        WriteLine(car.ShowInfo());
        car.ShowMessage();

        car.ShowMessage("Cambiando de modelo");
        car.ChangeModel("Honda");
        WriteLine(car.ShowInfo());

        Car.GeneralInfo();
    }
}


class Car
{
    public string? Model { get; set; }
    public int? Year { get; set; }


    public void ChangeModel(string newModel)
    {
        Model = newModel;
    }

    public string ShowInfo()
    {
        return $"Automovil: {Model}, ano: {Year}";
    }

    public void ShowMessage() => WriteLine("Este es un automovil\n");
    public void ShowMessage(string message) => WriteLine(message);

    public static void GeneralInfo()
    {
        WriteLine("EL automovil es uno de los transportes mas utilizados");
    }

}