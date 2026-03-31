using System;

namespace Domain.Models.ClassTask;

public class Rectangle : Shape
{
    protected double width = 1.0;
    protected double length = 1.0;
    public Rectangle(){}
    public Rectangle(double width, double length)
    {
        this.width = width;
        this.length = length;
    }
    public Rectangle(double width, double length, string color, bool filled)
    {
        this.width = width;
        this.length = length;
        this.color = color;
        this.filled = filled;
    }
    public double GetWidth()
    {
        return width;
    }
    public virtual void SetWidth(double width)
    {
        this.width = width;
    }
    public double GetLength()
    {
        return length;
    }
    public virtual void SetLength(double length)
    {
        this.length = length;
    }
    public override double GetArea()
    {
        return width * length;
    }
    public override double GetPerimeter()
    {
        return 2 * (width + length);
    }
    public override string ToString()
    {
        return $"Rectangle [Shape [color = {color}, filled = {filled}], width = {width}, length = {length}]";
    }
}
