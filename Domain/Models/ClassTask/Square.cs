using System;

namespace Domain.Models.ClassTask;

public class Square:Rectangle
{
    public Square(){}
    public Square(double side)
    {
        length = side;
        width = side;
    }
    public Square(double side, string color, bool filled)
    {
        length = side;
        this.color = color;
        this.filled = filled;
    }
    public override void SetWidth(double width)
    {
        this.width = width;
    }
    public override void SetLength(double length)
    {
        this.length = length;
    }
    public override string ToString()
    {
        return $"Square [Rectangle [Shape [color = {color}, filled = {filled}], width = {width}, length = {length}]]";
    }
}
