namespace Inferno_Infinity.Weapons
{
    using Interfaces;

    public class Axe : Weapon
    {
        private const int MinDamage = 5;
        private const int MaxDamage = 10;
        private const int Sockets = 4;

        public Axe(string weaponType, string name) : base(weaponType, name)
        {
            base.MinDamage = MinDamage * this.Modifier;
            base.MaxDamage = MaxDamage * this.Modifier;
            base.Sockets = new IGem[Sockets];
        }
    }
}
