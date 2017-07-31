namespace Inferno_Infinity.Gems
{
    public class Emerald : Gem
    {
        private const int Strength = 1;
        private const int Agility = 4;
        private const int Vitality = 9;

        public Emerald(string clarity) : base(clarity)
        {
            base.Strength = Strength + this.Modifier;
            base.Agility = Agility + this.Modifier;
            base.Vitality = Vitality + this.Modifier;
        }
    }
}
