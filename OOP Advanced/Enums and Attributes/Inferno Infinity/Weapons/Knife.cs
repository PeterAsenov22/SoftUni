namespace Inferno_Infinity.Weapons
{
    using Interfaces;

    public class Knife : Weapon
    {
        private const int MinDamage = 3;
        private const int MaxDamage = 4;
        private const int Sockets = 2;

        public Knife(string weaponType, string name) : base(weaponType, name)
        {
            base.MinDamage = MinDamage * this.Modifier;
            base.MaxDamage = MaxDamage * this.Modifier;
            base.Sockets = new IGem[Sockets];
        }
    }
}
