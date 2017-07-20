namespace Military_Elite.Interfaces
{
    using System.Collections.Generic;

    public interface IEngineer
    {
        List<Repair> Repairs { get; }
    }
}
