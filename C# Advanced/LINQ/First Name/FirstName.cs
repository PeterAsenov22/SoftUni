namespace First_Name
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FirstName
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(' ');
            var letters = Console.ReadLine().Split(' ');
            var container = new List<string>();

            foreach (var letter in letters)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i].StartsWith(letter.ToUpper()) || names[i].StartsWith(letter))
                    {
                        container.Add(names[i]);
                    }
                }
            }

            if (container.Count == 0)
            {
                Console.WriteLine("No match");
            }
            else
            {
                Console.WriteLine(string.Join(" ",container.OrderBy(x=>x).Take(1)));
            }
        }
    }
}
