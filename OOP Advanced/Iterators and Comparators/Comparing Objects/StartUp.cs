namespace Comparing_Objects
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var people = new List<Person>();

            while (input!="END")
            {
                var inputParams = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var person = new Person(inputParams[0],int.Parse(inputParams[1]),inputParams[2]);
                people.Add(person);

                input = Console.ReadLine();
            }

            var personIndex = int.Parse(Console.ReadLine()) - 1;
            var personToCompare = people[personIndex];
            people.RemoveAt(personIndex);

            int equalCount = 0;

            for (int i = 0; i < people.Count; i++)
            {
                var currentPerson = people[i];
                if (personToCompare.CompareTo(currentPerson)==0)
                {
                    equalCount++;
                }
            }

            if (equalCount == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalCount+1} {people.Count-equalCount} {people.Count+1}");
            }
        }
    }
}
