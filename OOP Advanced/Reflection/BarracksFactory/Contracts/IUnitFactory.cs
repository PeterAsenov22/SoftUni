using System;

namespace _03BarracksFactory.Contracts
{
    public interface IUnitFactory
    {
        IUnit CreateUnit(Type unitType);
    }
}
