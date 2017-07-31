namespace Inferno_Infinity.Gems
{
    public class Amethyst : Gem
    {
        private const int Strength = 2;
        private const int Agility = 8;
        private const int Vitality = 4;

        public Amethyst(string clarity) : base(clarity)
        {
            base.Strength = Strength + this.Modifier;
            base.Agility = Agility + this.Modifier;
            base.Vitality = Vitality + this.Modifier;
        }
    }
}
