using System.Runtime.CompilerServices;

partial class Program{
    static void TestingClass(){

        Vehicle toyota = new Vehicle();
        toyota.Brand = "Toyota";
        toyota.Model = "Corolla";
        toyota.Year = 2021;
        toyota.ShowInfo();

        Vehicle honda = new Vehicle{Brand="Honda", Model="Civic", Year=2019};
        honda.ShowInfo();

        Vehicle renault = new Vehicle("Nissan", "R24", 1997);
        renault.ShowInfo();

    }
}


class Vehicle{
    //propiedades
    public string? Brand{get; set;}
    public string? Model{get; set;}
    public int Year{get; set;}

    //Constructor
    public Vehicle(string brand, string model, int year){
        Brand = brand;
        Model = model;
        Year = year;
    }

    public Vehicle(){}

    //metodos
    public void ShowInfo()
    {
        WriteLine($"Este Vehiculo es un {Brand} {Model} del año {Year}");
    }
}
