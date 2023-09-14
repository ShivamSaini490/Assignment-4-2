using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public string FullCarName
    {
        get { return $"{Make} {Model} {Year}"; }
    }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car("Toyota", "Camry", 2022);

        string carName = myCar.FullCarName;
        Console.WriteLine("My car: " + carName);

        Console.ReadLine();
    }
}
