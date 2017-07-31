namespace Inferno_Infinity.Gems
{
    public class Ruby : Gem
    {
        private const int Strength = 7;
        private const int Agility = 2;
        private const int Vitality = 5;

        public Ruby(string clarity) : base(clarity)
        {
            base.Strength = Strength + this.Modifier;
            base.Agility = Agility + this.Modifier;
            base.Vitality = Vitality + this.Modifier;
        }       
    }
}
