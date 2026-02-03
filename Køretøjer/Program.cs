using System;

namespace Køretøjer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opret forskellige køretøjer
            Vehicle vehicle = new Vehicle("Generic Brand", 100);
            Car car = new Car("BMW", 250, 4);
            Bicycle bicycle = new Bicycle("Trek", 30, true);

            Console.WriteLine("Vehicle Test");
            Console.WriteLine($"Brand: {vehicle.Brand}, Max Speed: {vehicle.MaxSpeed} km/h");
            vehicle.Drive();

            Console.WriteLine("\nCar Test");
            Console.WriteLine($"Brand: {car.Brand}, Max Speed: {car.MaxSpeed} km/h, Doors: {car.NumberOfDoors}");
            car.Drive();

            Console.WriteLine("\nBicycle Test");
            Console.WriteLine($"Brand: {bicycle.Brand}, Max Speed: {bicycle.MaxSpeed} km/h, Has Bell: {bicycle.HasBell}");
            bicycle.Drive();

            Console.WriteLine("\nPolymorphism Test");
            Vehicle[] vehicles = { vehicle, car, bicycle };
            
            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine($"{v.GetType().Name}: ");
                v.Drive();
            }
        }
    }
}
