namespace Cat_Lady
{
    public class Siamese : Cat
    {
        private int earSize;

        public Siamese(string name, int earSize)
        {
            this.Name = name;
            this.earSize = earSize;
        }

        public override string ToString()
        {
            return $"Siamese {this.Name} {this.earSize}";
        }
    }
}
