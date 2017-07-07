namespace Raw_Data
{
    public class Cargo
    {
        private string type;
        private int weight;

        public Cargo(int weight, string type)
        {
            this.weight = weight;
            this.type = type;
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
    }
}
