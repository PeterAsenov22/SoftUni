namespace Car_Salesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private double? weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
        }

        public Car(string model, Engine engine, double weight)
            :this(model,engine)
        {
            this.weight = weight;
        }

        public Car(string model, Engine engine, string color)
            :this(model,engine)
        {
            this.color = color;
        }

        public Car(string model, Engine engine, double weight, string color)
            :this(model,engine)
        {
            this.weight = weight;
            this.color = color;
        }

        public string Model
        {
            get { return this.model; }
        }

        public Engine Engine
        {
            get { return this.engine; }
        }

        public double? Weight
        {
            get { return this.weight; }
        }

        public string Color
        {
            get { return this.color; }
        }
    }
}
