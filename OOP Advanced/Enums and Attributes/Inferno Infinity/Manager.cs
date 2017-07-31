namespace Inferno_Infinity
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using Factories;

    public class Manager : IManager
    {
        private IList<IWeapon> weapons;

        public Manager()
        {
            this.weapons = new List<IWeapon>();
        }

        public void Create(string weaponType, string weaponName)
        {
            IWeapon weapon = WeaponFactory.CreateWeapon(weaponType, weaponName);
            this.weapons.Add(weapon);
        }

        public void Add(string weaponName, int socketIndex, string gemType)
        {
            IWeapon weapon = this.weapons.First(x => x.Name == weaponName);
            IGem gem = GemFactory.CreateGem(gemType);
            weapon.Add(socketIndex,gem);
        }

        public void Remove(string weaponName, int socketIndex)
        {
            IWeapon weapon = this.weapons.First(x => x.Name == weaponName);
            weapon.Remove(socketIndex);
        }

        public string Print(string weaponName)
        {
            IWeapon weapon = this.weapons.First(x => x.Name == weaponName);
            return weapon.ToString();
        }
    }
}
