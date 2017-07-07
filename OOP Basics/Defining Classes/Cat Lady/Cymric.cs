namespace Cat_Lady
{
    public class Cymric : Cat
    {
        private double furLength;

        public Cymric(string name, double furLength)
        {
            this.Name = name;
            this.furLength = furLength;
        }

        public override string ToString()
        {
            return $"Cymric {this.Name} {this.furLength:F2}";
        }
    }
}
