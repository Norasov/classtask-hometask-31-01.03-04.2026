using System;

namespace Domain.Models.HomeTask;

public class ResizableCircle : Circle, Resizable
{
    public ResizableCircle(double radius) : base(radius)
    {
    }
    public override string ToString()
    {
        return $"ResizableCircle [{base.ToString()}]";
    }


    public void Resize(int percent)
    {
        radius *= percent / 100.0;
    }
}
