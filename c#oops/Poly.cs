using System;

public class Drawing
{
    public virtual double Area()
    {
        return 0;
    }
}

public class Circle1 : Drawing
{
    public double Radius { get; set; }
    public Circle1()
    {
        Radius = 5;
    }
    public override double Area()
    {
        return (3.14) * Math.Pow(Radius, 2);
    }
}

public class Square1 : Drawing
{
    public double Length { get; set; }
    public Square1()
    {
        Length = 6;
    }
    public override double Area()
    {
        return Math.Pow(Length, 2);
    }
}

public class Rectangle1 : Drawing
{
    public double Height { get; set; }
    public double Width { get; set; }
    public Rectangle1()
    {
        Height = 5.3;
        Width = 3.4;
    }
    public override double Area()
    {
        return Height * Width;
    }
}

class Poly
{
    static void Main(string[] args)
    {

        Drawing circle = new Circle1();
        Console.WriteLine("Area :" + circle.Area());

        Drawing square = new Square1();
        Console.WriteLine("Area :" + square.Area());

        Drawing rectangle = new Rectangle1();
        Console.WriteLine("Area :" + rectangle.Area());
    }
}