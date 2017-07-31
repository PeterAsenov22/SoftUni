namespace Strategy_Pattern
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var firstSet = new SortedSet<Person>(new PersonComparator());
            var secondSet = new SortedSet<Person>(new AnotherPersonComparator());

            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                var currentPersonParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var currentPerson = new Person(currentPersonParams[0],int.Parse(currentPersonParams[1]));

                firstSet.Add(currentPerson);
                secondSet.Add(currentPerson);
            }

            foreach (var person in firstSet)
            {
                Console.WriteLine(person);
            }

            foreach (var person in secondSet)
            {
                Console.WriteLine(person);
            }
        }
    }
}
