namespace Inferno_Infinity.Weapons
{
    using Interfaces;

    public class Sword : Weapon
    {
        private const int MinDamage = 4;
        private const int MaxDamage = 6;
        private const int Sockets = 3;

        public Sword(string weaponType, string name) : base(weaponType, name)
        {
            base.MinDamage = MinDamage * this.Modifier;
            base.MaxDamage = MaxDamage * this.Modifier;
            base.Sockets = new IGem[Sockets];
        }
    }
}
