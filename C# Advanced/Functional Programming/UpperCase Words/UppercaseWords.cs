namespace UpperCase_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UppercaseWords
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).ToList();
            Func<List<string>, List<string>> uppercase =
                words => words.Where(word => word[0].ToString() == word[0].ToString().ToUpper()).ToList();
            var uppercaseWords = uppercase(text);

            foreach (var word in uppercaseWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
