namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(Type unitType)
        {
            IUnit instance = (IUnit)Activator.CreateInstance(unitType);
            return instance;
        }
    }
}
