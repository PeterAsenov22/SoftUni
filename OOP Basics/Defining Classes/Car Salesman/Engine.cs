namespace Car_Salesman
{
    public class Engine
    {
        private string model;
        private int power;
        private int? displacement;
        private string efficeincy;

        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
        }

        public Engine(string model, int power, int displacement)
            :this(model,power)        
        {
            this.displacement = displacement;
        }

        public Engine(string model, int power, string efficeincy)
            :this(model,power)
        {
            this.efficeincy = efficeincy;
        }

        public Engine(string model, int power, int displacement, string efficeincy)
            :this(model,power)
        {
            this.displacement = displacement;
            this.efficeincy = efficeincy;
        }

        public string Model
        {
            get { return this.model; }
        }

        public int Power
        {
            get { return this.power; }
        }

        public int? Displacement
        {
            get { return this.displacement; }
        }

        public string Efficiency
        {
            get { return this.efficeincy; }
        }
    }
}
