namespace Pet_Clinics
{
    using System.Collections.Generic;
    using Pet_Clinics.Interfaces;
    using System.Linq;

    public class ClinicManager:IClinicManager
    {
        public ClinicManager()
        {
            this.Pets = new List<IPet>();
            this.Clinics = new List<IClinic>();
        }

        public IList<IPet> Pets { get; private set; }

        public IList<IClinic> Clinics { get; private set; }

        public void AddNewPet(IPet pet)
        {
            this.Pets.Add(pet);
        }

        public void AddNewClinic(IClinic clinic)
        {
            this.Clinics.Add(clinic);
        }

        public bool Add(string petName, string clinicName)
        {
            IPet pet = this.Pets.First(x => x.Name == petName);
            IClinic clinic = this.Clinics.First(x => x.Name == clinicName);
            return clinic.AddPet(pet);
        }

        public bool Release(string clinicName)
        {
            IClinic clinic = this.Clinics.First(x => x.Name == clinicName);
            IPet pet =  clinic.ReleasePet();
            if (pet != null)
            {
                this.Pets.Remove(pet);
                return true;
            }

            return false;
        }

        public bool HasEmptyRooms(string clinicName)
        {
            IClinic clinic = this.Clinics.First(x => x.Name == clinicName);
            return clinic.HasEmptyRooms();
        }

        public string Print(string clinicName)
        {
            IClinic clinic = this.Clinics.First(x => x.Name == clinicName);
            return clinic.Print();
        }

        public string Print(string clinicName, int room)
        {
            IClinic clinic = this.Clinics.First(x => x.Name == clinicName);
            return clinic.Print(room);
        }
    }
}
