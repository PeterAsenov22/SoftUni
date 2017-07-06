namespace Valid_Usernames_2
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Usernames
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] {' ', '\\', '/', '(', ')'},StringSplitOptions.RemoveEmptyEntries);
            var regex = new Regex(@"\b[A-Za-z][\w]{2,24}\b");
            var usernamesList = new List<string>();

            foreach (var word in input)
            {
                if (regex.IsMatch(word))
                {
                    usernamesList.Add(word);
                }
            }

            var biggestLength = 0;
            var firstUserIndex = 0;

            for (int i = 0; i < usernamesList.Count-1; i++)
            {
                if (usernamesList[i].Length + usernamesList[i + 1].Length > biggestLength)
                {
                    biggestLength = usernamesList[i].Length + usernamesList[i + 1].Length;
                    firstUserIndex = i;
                }
            }

            Console.WriteLine(usernamesList[firstUserIndex]);
            Console.WriteLine(usernamesList[firstUserIndex+1]);
        }
    }
}
