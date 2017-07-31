namespace Inferno_Infinity.Weapons
{
    using System;
    using Interfaces;

    [Weapon("Pesho",3, "Used for C# OOP Advanced Course - Enumerations and Attributes.","Pesho","Svetlio")]
    public abstract class Weapon : IWeapon
    {
        protected Weapon(string weaponType, string name)
        {
            this.Name = name;
            this.WeaponType = (WeaponType)Enum.Parse(typeof(WeaponType), weaponType);
        }

        public string Name { get; private set; }

        public int MaxDamage { get; protected set; }

        public int MinDamage { get; protected set; }

        public IGem[] Sockets { get; protected set; }

        public WeaponType WeaponType { get; private set; }

        public int Strength { get; private set; }

        public int Agility { get; private set; }

        public int Vitality { get; private set; }

        protected int Modifier => (int) this.WeaponType;

        public void Add(int socketIndex, IGem gem)
        {
            if (this.Sockets.Length > socketIndex && socketIndex >= 0)
            {
                if (this.Sockets[socketIndex] != null)
                {
                    this.Remove(socketIndex);
                }

                this.Sockets[socketIndex] = gem;
                this.Strength += gem.Strength;
                this.Agility += gem.Agility;
                this.Vitality += gem.Vitality;
                AddPower(gem);
            }
        }

        public void Remove(int socketIndex)
        {
            if (this.Sockets.Length > socketIndex && socketIndex >= 0)
            {
                if (this.Sockets[socketIndex] != null)
                {
                    IGem gem = this.Sockets[socketIndex];
                    this.Sockets[socketIndex] = null;
                    this.Strength -= gem.Strength;
                    this.Agility -= gem.Agility;
                    this.Vitality -= gem.Vitality;
                    RemovePower(gem);
                }
            }
        }

        private void AddPower(IGem gem)
        {
            this.MinDamage += gem.Strength * 2 + gem.Agility;
            this.MaxDamage += gem.Strength * 3 + gem.Agility * 4;
        }

        private void RemovePower(IGem gem)
        {
            this.MinDamage -= gem.Strength * 2 + gem.Agility;
            this.MaxDamage -= gem.Strength * 3 + gem.Agility * 4;
        }

        public override string ToString()
        {
            return
                $"{this.Name}: {this.MinDamage}-{this.MaxDamage} Damage, +{this.Strength} Strength, +{this.Agility} Agility, +{this.Vitality} Vitality";
        }
    }
}
