namespace Explicit_Interfaces
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            while (input!="End")
            {
                var inputParams = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var citizen = new Citizen(inputParams[0],inputParams[1],int.Parse(inputParams[2]));

                IResident resident = citizen;
                IPerson person = citizen;

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());

                input = Console.ReadLine();
            }
        }
    }
}
