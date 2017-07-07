namespace Google
{
    public class Car
    {
        private string model;
        private int speed;

        public Car()
        {          
        }

        public Car(string model, int speed)
        {
            this.model = model;
            this.speed = speed;
        }

        public int Speed
        {
            get { return this.speed; }
        }

        public string Model
        {
            get { return this.model; }
        }

        public override string ToString()
        {
            if (this.model != null)
            {
                return $"{this.model} {this.speed}";
            }
            else
            {
                return $"";
            }
        }
    }
}
