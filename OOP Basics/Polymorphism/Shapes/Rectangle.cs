using System;

class Rectangle : Shape
{
    private double height;
    private double width;

    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    private double Height
    {
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height should be more than zero!");
            }

            this.height = value;
        }
    }

    private double Width
    {
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width should be more than zero!");
            }

            this.width = value;
        }
    }

    public override double CalculatePerimeter()
    {
        return 2 * (this.height + this.width);
    }

    public override double CalculateArea()
    {
        return this.height * this.width;
    }

    public sealed override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}

