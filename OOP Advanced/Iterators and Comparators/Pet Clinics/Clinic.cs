namespace Pet_Clinics
{
    using System.Linq;

    using System.Text;
    using Pet_Clinics.Interfaces;

    public class Clinic : IClinic
    {
        public Clinic(string name, int rooms)
        {
            this.Name = name;
            this.Rooms = new Rooms(rooms);     
        }

        public string Name { get; private set; }
        
        public Rooms Rooms { get; private set; }

        public bool AddPet(IPet pet)
        {
            foreach (var room in this.Rooms)
            {
                if (room.IsEmpty)
                {
                    room.AddPet(pet);
                    return true;
                }
            }

            return false;
        }

        public IPet ReleasePet()
        {
            for (int i = this.Rooms.AllRooms.Count / 2; i < this.Rooms.AllRooms.Count; i++)
            {
                if (!this.Rooms.AllRooms[i].IsEmpty)
                {
                    IPet pet = this.Rooms.AllRooms[i].Pet;
                    this.Rooms.AllRooms[i] = new Room();
                    return pet;
                }
            }

            for (int i = 0; i < this.Rooms.AllRooms.Count / 2; i++)
            {
                if (!this.Rooms.AllRooms[i].IsEmpty)
                {
                    IPet pet = this.Rooms.AllRooms[i].Pet;
                    this.Rooms.AllRooms[i] = new Room();
                    return pet;
                }
            }

            return null;
        }

        public bool HasEmptyRooms()
        {
            return this.Rooms.AllRooms.Any(x=>x.IsEmpty);
        }

        public string Print()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < this.Rooms.AllRooms.Count; i++)
            {
                sb.AppendLine(this.Print(i + 1));
            }

            return sb.ToString().Trim();
        }

        public string Print(int room)
        {
            if (this.Rooms.AllRooms[room - 1].IsEmpty)
            {
                return "Room empty";
            }

            IPet pet = this.Rooms.AllRooms[room - 1].Pet;
            return $"{pet.Name} {pet.Age} {pet.Kind}";
        }
    }
}
