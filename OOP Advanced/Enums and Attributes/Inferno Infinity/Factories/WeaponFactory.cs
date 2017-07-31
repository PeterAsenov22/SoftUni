namespace Inferno_Infinity.Factories
{
    using System;
    using Interfaces;
    using Weapons;

    public static class WeaponFactory
    {
        public static IWeapon CreateWeapon(string type, string name)
        {
            var typeArgs = type.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            switch (typeArgs[1])
            {
                case "Axe":
                    return new Axe(typeArgs[0],name);
                case "Sword":
                    return new Sword(typeArgs[0],name);
                case "Knife":
                    return new Knife(typeArgs[0],name);
            }

            return null;
        }
    }
}
