namespace Group_By_Group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GroupByGroup
    {
        public static void Main()
        {
            var persons = new List<Person>();
            var input = Console.ReadLine();

            while (input!="END")
            {
                var inputParams = input.Split(' ');
                var person = new Person()
                {
                    FirstName = inputParams[0],
                    LastName = inputParams[1],
                    Group = int.Parse(inputParams[2])
                };

                persons.Add(person);
                input = Console.ReadLine();
            }

            var groupped = persons.GroupBy(x => x.Group).ToList();
            foreach (var group in groupped.OrderBy(x=>x.Key))
            {
                var listOfPersonsInGroup = new List<string>();
                foreach (var person in group)
                {
                    listOfPersonsInGroup.Add($"{person.FirstName} {person.LastName}");
                }

                Console.WriteLine($"{group.Key} - {string.Join(", ",listOfPersonsInGroup)}");
            }
        }
    }
}
