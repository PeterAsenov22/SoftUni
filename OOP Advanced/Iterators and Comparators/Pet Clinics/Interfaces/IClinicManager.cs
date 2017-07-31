namespace Pet_Clinics.Interfaces
{
    using System.Collections.Generic;

    public interface IClinicManager
    {
        IList<IPet> Pets { get; }

        IList<IClinic> Clinics { get; }

        void AddNewPet(IPet pet);

        void AddNewClinic(IClinic clinic);

        bool Add(string petName, string clinicName);

        bool Release(string clinicName);

        bool HasEmptyRooms(string clinicName);

        string Print(string clinicName);

        string Print(string clinicName, int room);
    }
}
