namespace Pet_Clinics.Interfaces
{ 
    public interface IRoom
    {
        IPet Pet { get; }

        bool IsEmpty { get; }

        void AddPet(IPet pet);
    }
}
