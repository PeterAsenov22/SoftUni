namespace Cat_Lady
{
    public class StreetExtraordinaire : Cat
    {
        private int decibels;

        public StreetExtraordinaire(string name, int decibels)
        {
            this.Name = name;
            this.decibels = decibels;
        }

        public override string ToString()
        {
            return $"StreetExtraordinaire {this.Name} {this.decibels}";
        }
    }
}
