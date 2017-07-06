namespace Palindroms
{
    using System;
    using System.Collections.Generic;

    public class Palindroms
    {
        public static void Main()
        {
            var textWords = Console.ReadLine().Split(new[] {'.', ' ', ',', '!', '?'},
                StringSplitOptions.RemoveEmptyEntries);
            var list = new SortedSet<string>();

            foreach (var word in textWords)
            {
                if (word.Length == 1)
                {
                    list.Add(word);
                }
                else
                {
                    var isPalindrom = true;
                    for (int i = 0; i < word.Length/2; i++)
                    {
                        if (word[i] != word[word.Length - 1 - i])
                        {
                            isPalindrom = false;
                        }
                    }

                    if (isPalindrom)
                    {
                        list.Add(word);
                    }
                }
            }

            Console.WriteLine($"[{string.Join(", ",list)}]");
        }
    }
}
