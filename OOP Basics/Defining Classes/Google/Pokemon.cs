namespace Google
{
    public class Pokemon
    {
        private string name;
        private string type;

        public Pokemon(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public string Type
        {
            get { return this.type; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public override string ToString()
        {
            if (this.name != null)
            {
                return $"{this.name} {this.type}";
            }
            else
            {
                return $"";
            }
        }
    }
}
