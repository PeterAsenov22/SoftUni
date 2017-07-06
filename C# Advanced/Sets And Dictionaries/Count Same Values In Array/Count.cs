namespace Count_Same_Values_In_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Count
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var dictionary = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if(!dictionary.ContainsKey(num))
                {
                    dictionary[num] = 0;
                }

                dictionary[num]++;
            }

            foreach (var num in dictionary)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
