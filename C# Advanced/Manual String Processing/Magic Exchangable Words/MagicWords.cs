namespace Magic_Exchangable_Words
{
    using System;
    using System.Collections.Generic;

    public class MagicWords
    {
        public static void Main()
        {
            var strings = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var first = strings[0];
            var second = strings[1];
            var isMagic = IsMagic(first, second);
            Console.WriteLine(isMagic.ToString().ToLower());
        }

        private static bool IsMagic(string firts, string second)
        {
            var firstChars = new HashSet<char>();
            var secondChars = new HashSet<char>();
            var firstLetters = firts.ToCharArray();
            var secondLetters = second.ToCharArray();

            foreach (var letter in firstLetters)
            {
                firstChars.Add(letter);
            }

            foreach (var letter in secondLetters)
            {
                secondChars.Add(letter);
            }

            if (firstChars.Count == secondChars.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
