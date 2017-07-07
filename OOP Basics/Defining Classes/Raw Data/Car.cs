namespace Raw_Data
{
    using System.Collections.Generic;

    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public Car(string model, Engine engine, Cargo cargo,
            List<Tire> tires)
        {
            this.Model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tires = tires;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }
        }

        public Cargo Cargo
        {
            get { return this.cargo; }
        }

        public List<Tire> Tires
        {
            get { return this.tires; }
        }
    }
}
