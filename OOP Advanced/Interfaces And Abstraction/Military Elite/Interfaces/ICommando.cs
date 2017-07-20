namespace Military_Elite.Interfaces
{
    using System.Collections.Generic;

    public interface ICommando
    {
        List<Mission> Missions { get; }
    }
}
