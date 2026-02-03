namespace Geometriske_Figurer;

// Abstrakt basisklasse for geometriske figurer
public abstract class Shape
{
    // Abstrakte metoder som skal implementeres i underklasserne
    public abstract double GetArea();
    public abstract double GetPerimeter();
}

// Circle klasse der arver fra Shape
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    // Implementering af areal for cirkel: π * r²
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    // Implementering af omkreds for cirkel: 2 * π * r
    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

// Rectangle klasse der arver fra Shape
public class Rectangle : Shape
{
    public double Height { get; set; }
    public double Width { get; set; }

    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }

    // Implementering af areal for rektangel: højde * bredde
    public override double GetArea()
    {
        return Height * Width;
    }

    // Implementering af omkreds for rektangel: 2 * (højde + bredde)
    public override double GetPerimeter()
    {
        return 2 * (Height + Width);
    }
}
