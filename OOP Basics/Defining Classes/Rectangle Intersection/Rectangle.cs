using System;

namespace Rectangle_Intersection
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double topleftX;
        private double topleftY;

        public Rectangle(string id, double width, double height, double topleftX, double topleftY)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.topleftX = topleftX;
            this.topleftY = topleftY;
        }

        public string ID
        {
            get { return this.id; }
        }

        public bool Intersect(Rectangle secondRec)
        {
            var intersect = false;
            if (Math.Abs(this.topleftX) < Math.Abs(secondRec.topleftX + secondRec.width))
            {
                if (Math.Abs(this.topleftX + this.width) >= Math.Abs(secondRec.topleftX))
                {
                    if (this.topleftY < Math.Abs((secondRec.topleftY - secondRec.height)))
                    {
                        if (Math.Abs(this.topleftY + this.height) >= Math.Abs(secondRec.topleftY))
                        {
                            intersect = true;
                        }
                    }
                }
            }

            return intersect;
        }
    }
}
