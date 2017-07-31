namespace Froggy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var stones = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            var frog = new Frog(stones);

            var jumpedStones = new List<int>();

            foreach (var stone in frog)
            {
                jumpedStones.Add(stone);
            }

            Console.WriteLine(string.Join(", ",jumpedStones));
        }
    }
}
