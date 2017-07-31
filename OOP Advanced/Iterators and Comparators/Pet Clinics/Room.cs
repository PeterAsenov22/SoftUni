namespace Pet_Clinics
{
    using Pet_Clinics.Interfaces;

    public class Room:IRoom
    {
        public Room()
        {
            this.IsEmpty = true;
        }

        public IPet Pet { get; private set; }

        public bool IsEmpty { get; private set; }

        public void AddPet(IPet pet)
        {
            this.Pet = pet;
            this.IsEmpty = false;
        }
    }
}
