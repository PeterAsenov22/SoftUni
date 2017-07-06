namespace Count_Symbols
{
    using System;
    using System.Collections.Generic;

    public class CountSymbols
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            var dictionary = new SortedDictionary<char,int>();

            foreach (var element in input)
            {
                if (!dictionary.ContainsKey(element))
                {
                    dictionary[element] = 0;
                }

                dictionary[element]++;
            }

            foreach (var elem in dictionary)
            {
                Console.WriteLine($"{elem.Key}: {elem.Value} time/s");
            }
        }
    }
}
