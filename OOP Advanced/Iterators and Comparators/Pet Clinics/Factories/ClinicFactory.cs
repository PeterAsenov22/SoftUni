namespace Pet_Clinics.Factories
{
    using System;
    using Pet_Clinics.Interfaces;

    public static class ClinicFactory
    {
        public static IClinic CreateClinic(string[] clinicInfo)
        {
            int rooms = int.Parse(clinicInfo[3]);
            if (rooms % 2 == 0)
            {
                throw new Exception();
            }

            IClinic clinic  = new Clinic(clinicInfo[2],int.Parse(clinicInfo[3]));
            return clinic;
        }
    }
}
