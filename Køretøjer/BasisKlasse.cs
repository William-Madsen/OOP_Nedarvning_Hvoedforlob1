namespace Køretøjer;

public class Vehicle
{
    public string Brand { get; set; }
    public int MaxSpeed { get; set; }

    public Vehicle(string brand, int maxSpeed)
    {
        Brand = brand;
        MaxSpeed = maxSpeed;
    }

    public virtual void Drive()
    {
        Console.WriteLine("The vehicle is moving");
    }
}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string brand, int maxSpeed, int numberOfDoors) : base(brand, maxSpeed)
    {
        NumberOfDoors = numberOfDoors;
    }

    public override void Drive()
    {
        Console.WriteLine("The car is driving");
    }
}

public class Bicycle : Vehicle
{
    public bool HasBell { get; set; }

    public Bicycle(string brand, int maxSpeed, bool hasBell) : base(brand, maxSpeed)
    {
        HasBell = hasBell;
    }

    public override void Drive()
    {
        Console.WriteLine("The bicycle is pedaling");
    }
}
