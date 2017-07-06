namespace Knights_of_Honor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class KnightsOfHonor
    {
        public static void Main()
        {
            var knights = Console.ReadLine().Split(new char[] {' ', '\t', '\n', '\r'},
                StringSplitOptions.RemoveEmptyEntries).ToList();
            Action<List<string>> printSir = list => list.ForEach(knight => Console.WriteLine($"Sir {knight}"));
            printSir(knights);
        }
    }
}
