using System;

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    private double Radius
    {
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Radius should be more than zero!");
            }
            this.radius = value;
        }
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * this.radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * this.radius * this.radius;
    }

    public sealed override string Draw()
    {
        return base.Draw() + "Circle";
    }
}

