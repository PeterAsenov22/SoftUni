namespace Reverse_and_exclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseAndExclude
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();
            var divider = int.Parse(Console.ReadLine());
            var filtered = new List<int>();

            Predicate<int> predicate = i => i % divider == 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (!predicate(numbers[i]))
                {
                    filtered.Add(numbers[i]);
                }
            }

            filtered.Reverse();
            Console.WriteLine(string.Join(" ",filtered));
        }
    }
}
