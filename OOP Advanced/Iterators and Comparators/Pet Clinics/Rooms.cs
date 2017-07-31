namespace Pet_Clinics
{
    using System.Collections;
    using System.Collections.Generic;
    using Interfaces;

    public class Rooms:IRooms
    {
        public IList<Room> AllRooms { get; private set; }

        public Rooms(int count)
        {
            this.AllRooms = new List<Room>();

            for (int i = 0; i < count; i++)
            {
                this.AllRooms.Add(new Room());
            }
        }

        public IEnumerator<IRoom> GetEnumerator()
        {
            var roomsCount = this.AllRooms.Count;
            yield return this.AllRooms[roomsCount / 2];

            for (int i = 0; i < roomsCount / 2; i++)
            {
                yield return this.AllRooms[(roomsCount / 2) - i - 1];
                yield return this.AllRooms[(roomsCount / 2) + i + 1];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
