namespace Inferno_Infinity.Interfaces
{
    using Weapons;

    public interface IWeapon
    {
        string Name { get; }

        int MaxDamage { get; }

        int MinDamage { get; }

        IGem[] Sockets { get; }

        WeaponType WeaponType { get; }

        int Strength { get; }

        int Agility { get; }

        int Vitality { get; }

        void Add(int socketIndex, IGem gem);

        void Remove(int socketIndex);
    }
}
