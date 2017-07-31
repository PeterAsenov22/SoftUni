namespace Pet_Clinics.Interfaces
{

    public interface IClinic
    {
        string Name { get; }

        Rooms Rooms { get; }

        bool AddPet(IPet pet);

        IPet ReleasePet();

        bool HasEmptyRooms();

        string Print();

        string Print(int room);
    }
}
