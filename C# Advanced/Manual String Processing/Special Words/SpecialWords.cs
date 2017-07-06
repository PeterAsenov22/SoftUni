namespace Special_Words
{
    using System;
    using System.Collections.Generic;

    public class SpecialWords
    {
        public static void Main()
        {
            var specialWords = Console.ReadLine().Split();
            var text = Console.ReadLine()
                .Split(new[] {'(', ')', '[', ']', '<', '>', ' ', ',', '-', '!', '?', '‘', '’'},
                    StringSplitOptions.RemoveEmptyEntries);
            var dictionary = new Dictionary<string,int>();

            foreach (var special in specialWords)
            {
                dictionary[special] = 0;
            }

            foreach (var word in text)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
            }

            foreach (var specialWord in dictionary)
            {
                Console.WriteLine($"{specialWord.Key} - {specialWord.Value}");
            }
        }
    }
}
