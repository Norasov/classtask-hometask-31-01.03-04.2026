using System;

namespace Domain.Models.ClassTask;

public class Circle : Shape
{
    protected double radius = 1.0;
    public Circle(){}
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public Circle(double radius, string color, bool filled)
    {
        this.radius = radius;
        this.color = color;
        this.filled = filled;
    }
    public double GetRadius()
    {
        return radius;
    }
    public void SetRadius(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(radius,2);
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }
    public override string ToString()
    {
        return $"Circle [Shape [color = {color}, filled = {filled}], radius = {radius}]";
    }
}
