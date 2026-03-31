using System;

namespace Domain.Models.HomeTask;

public class Circle:GeometricObject
{
    protected double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public override string ToString()
    {
        return $"Circle [radius = {radius}]";
    }
    
}
