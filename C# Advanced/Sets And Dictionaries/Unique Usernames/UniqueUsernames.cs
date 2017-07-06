namespace Unique_Usernames
{
    using System;
    using System.Collections.Generic;

    public class UniqueUsernames
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var uniqueUsernames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                uniqueUsernames.Add(input);
            }

            foreach (var username in uniqueUsernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
