namespace Pet_Clinics.Factories
{
    public static class PetFactory
    {
        public static IPet CreatePet(string[] petInfo)
        {
            IPet pet = new Pet(petInfo[2],int.Parse(petInfo[3]),petInfo[4]);
            return pet;
        }
    }
}
