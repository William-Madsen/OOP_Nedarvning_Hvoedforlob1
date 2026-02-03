using System;

namespace Geometriske_Figurer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test af geometriske figurer\n");

            Circle circle = new Circle(5.0);
            Console.WriteLine("Cirkel med radius 5:");
            Console.WriteLine($"Areal: {circle.GetArea():F2}");
            Console.WriteLine($"Omkreds: {circle.GetPerimeter():F2}\n");

            Rectangle rectangle = new Rectangle(4.0, 6.0);
            Console.WriteLine("Rektangel med højde 4 og bredde 6:");
            Console.WriteLine($"Areal: {rectangle.GetArea():F2}");
            Console.WriteLine($"Omkreds: {rectangle.GetPerimeter():F2}\n");

            Shape[] shapes = { circle, rectangle };
            
            Console.WriteLine("Test af polymorfisme:");
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine($"Figur {i + 1}:");
                Console.WriteLine($"Areal: {shapes[i].GetArea():F2}");
                Console.WriteLine($"Omkreds: {shapes[i].GetPerimeter():F2}\n");
            }
        }
    }
}
