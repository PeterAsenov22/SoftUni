namespace _02.Blobs.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Interfaces;

    public static class AttackFactory
    {
        public static IAttack CreateAttack(string attackName)
        {
            Type attackType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == attackName);
            return (IAttack) Activator.CreateInstance(attackType);
        }
    }
}
