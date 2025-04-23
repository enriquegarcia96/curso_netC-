using System.Runtime.CompilerServices;

partial class Program
{
    static void Methods()
    {

        Car car = new Car();
        car.Model = "YAris";
        car.Year = 2022;
        WriteLine(car.ShowInfo());
        // car.ShowMessage();

        // car.ShowMessage("Cambiando de modelo");
        // car.ChangeModel("Honda");
        // WriteLine(car.ShowInfo());

        // Car.GeneralInfo();

        // un constructor
        Car sportCar = new Car("Ferrari", 2020);
        WriteLine(sportCar.ShowInfo());

        // sintanxis simplificada
        Car collectionCar = new Car{Model="Cadillac", Year= 1997};
        WriteLine(collectionCar.ShowInfo());

        //lista de objetos;
        WriteLine("Listado de automoviles: ");
        List<Car> cars = new(){
            new Car(){Model="Duster", Year=2021},
            new Car(){Model="Toyota", Year=2000},
            new Car(){Model="Nissa", Year=1996}
        };


        foreach (var item in cars)
        {
            WriteLine(item.ShowInfo());
        }
    }
}


class Car
{
    public string? Model { get; set; }
    public int? Year { get; set; }

    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }

    public Car(){}

    //Destructor (~)
    ~Car()
    {
        WriteLine("Destructor llamado. Recurso liberado");
    }

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