namespace Ferari
{
    public class Ferrari:ICar
    {
        public string Driver { get; }

        public string Model { get; }

        public Ferrari(string driver)
        {
            this.Driver = driver;
            this.Model = "488-Spider";
        }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string GasPedal()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.Brakes()}/{this.GasPedal()}/{this.Driver}";
        }
    }
}
