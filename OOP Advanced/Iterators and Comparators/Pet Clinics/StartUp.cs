namespace Pet_Clinics
{
    using System;
    using Factories;
    using Interfaces;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            IClinicManager clinicManager = new ClinicManager();

            for (int i = 0; i < numberOfCommands; i++)
            {
                var cmdArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    switch (cmdArgs[0])
                    {
                        case "Create":
                            if (cmdArgs[1] == "Pet")
                            {
                                IPet pet = PetFactory.CreatePet(cmdArgs);
                                clinicManager.AddNewPet(pet);
                            }
                            else
                            {
                                IClinic clinic = ClinicFactory.CreateClinic(cmdArgs);
                                clinicManager.AddNewClinic(clinic);
                            }
                            break;
                        case "Add":
                            Console.WriteLine(clinicManager.Add(cmdArgs[1], cmdArgs[2]));
                            break;
                        case "Release":
                            Console.WriteLine(clinicManager.Release(cmdArgs[1]));
                            break;
                        case "HasEmptyRooms":
                            Console.WriteLine(clinicManager.HasEmptyRooms(cmdArgs[1]));
                            break;
                        case "Print":
                            if (cmdArgs.Length == 2)
                            {
                                Console.WriteLine(clinicManager.Print(cmdArgs[1]));
                            }
                            else
                            {
                                Console.WriteLine(clinicManager.Print(cmdArgs[1], int.Parse(cmdArgs[2])));
                            }
                            break;
                        default:
                            throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Operation!");
                }
            }
        }
    }
}
