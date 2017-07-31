namespace Pet_Clinics.Interfaces
{
    using System.Collections.Generic;

    public interface IRooms:IEnumerable<IRoom>
    {
        IList<Room> AllRooms { get;}
    }
}
