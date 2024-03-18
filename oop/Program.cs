using System;
class Car {
    //git
    //*** Encapsulation :3
    //Private Attributes
    private string Model;
    private string Make;
    private int Year;

    //Properties
    //The Capsule
    public string model
    {
        get { return Model; }
        set { Model = value; }
    }

    public string make
    {
        get { return Make; }
        set { Make = value; }
    }

    public int year
    {
        get { return Year; }
        set { Year = value; }
    }
    //Encapsulation :3 ***

    //Constructor
    public Car(string model, string make, int year) 
    {

        Model = model;
        Make = make;
        Year = year;
    }

    //Methods
    public void Drive() {
        Console.WriteLine("The car is now running.");
    }

    public void Stop() {
        Console.WriteLine("The car has stopped.");
    }

    //*** Polymorphism :3
    virtual public void Horn() {
        Console.WriteLine("The car makes car-horn sound.");
    }

}

    //*** Inheritance :3
class Truck : Car
{
    //Inherited Constructor
    public Truck(string model, string make, int year) : base(model,make,year)
    {

    }

    //Inherited Method
    public void Drive() {
        base.Drive();
    }

    public void Stop() {
        base.Stop();
    }

    //Polymorphed Method
    override public void Horn() {
        Console.WriteLine("The truck makes truck-horn sound.");
    }

}

class Van : Car
{
    //Inherited Constructor
    public Van(string model, string make, int year) : base(model,make,year)
    {

    }

    //Inherited Method
    public void Drive() {
        base.Drive();
    }

    public void Stop() {
        base.Stop();
    }

    //Polymorphed Method
    override public void Horn() {
        Console.WriteLine("The van makes van-horn sound.");
    }

}


    //Inheritance :3 ***
    //Polymorphism :3 ***


class Program {
    static void Main(string[] args) {
        Car myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.model}, Make: {myCar.make}, Year: {myCar.year}");
        myCar.Drive();
        myCar.Stop();
        myCar.Horn();

        Truck myTruck = new Truck("Ford", "F-150", 2024);
        Console.WriteLine($"Model: {myTruck.model}, Make: {myTruck.make}, Year: {myTruck.year}");
        myTruck.Drive();
        myTruck.Stop();
        myTruck.Horn();

        Van myVan = new Van("Volkswagen", "trasporter", 2021);
        Console.WriteLine($"Model: {myVan.model}, Make: {myVan.make}, Year: {myVan.year}");
        myVan.Drive();
        myVan.Stop();
        myVan.Horn();

    }
}

//*Objectives check*
//Encapsulation : DONE
//Inheritance : DONE
//Polymorphism : on-going
//Abstraction : Pending
