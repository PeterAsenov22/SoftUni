using System;

namespace Class_Box
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Lenght = length;
            this.Width = width;
            this.Height = height;
        }

        private double Lenght
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }

        private double Width
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }

        private double Height
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            return 2 * (this.height * this.length + this.length * this.width + this.height * this.width);
        }

        public double LateralSurfaceArea()
        {
            return 2 * (this.length * this.height + this.width * this.height);
        }

        public double Volume()
        {
            return this.width * this.height * this.length;
        }
    }
}
