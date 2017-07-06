namespace Filter_By_Age
{
    using System;
    using System.Collections.Generic;

    public class FilterByAge
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string,int>();

            for (int i = 0; i < n; i++)
            {
                var inputParams = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);
                var name = inputParams[0];
                var age = int.Parse(inputParams[1]);
                dictionary[name] = age;
            }

            var condition = Console.ReadLine();
            var ageCondition = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            var filteredDictionary = Filter(condition, dictionary, ageCondition);

            if (format == "age")
            {
                foreach (var person in filteredDictionary)
                {
                    Console.WriteLine(person.Value);
                }
            }
            else if(format == "name")
            {
                foreach (var person in filteredDictionary)
                {
                    Console.WriteLine(person.Key);
                }
            }
            else
            {
                foreach (var person in filteredDictionary)
                {
                    Console.WriteLine($"{person.Key} - {person.Value}");
                }
            }
        }

        public static Dictionary<string,int> Filter(string condition, Dictionary<string, int> dictionary,
            int ageCondition)
        {
            var filtered = new Dictionary<string, int>();
            if (condition == "older")
            {          
                foreach (var person in dictionary)
                {
                    if (person.Value > ageCondition)
                    {
                        filtered[person.Key] = person.Value;
                    }
                }
            }
            else
            {
                foreach (var person in dictionary)
                {
                    if (person.Value < ageCondition)
                    {
                        filtered[person.Key] = person.Value;
                    }
                }
            }

            return filtered;
        }
    }
}
