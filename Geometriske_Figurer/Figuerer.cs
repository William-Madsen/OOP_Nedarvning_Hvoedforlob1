namespace Geometriske_Figurer;

public abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

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
