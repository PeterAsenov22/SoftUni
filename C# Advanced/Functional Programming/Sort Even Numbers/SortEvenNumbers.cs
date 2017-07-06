namespace Sort_Even_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortEvenNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            Func<List<int>, List<int>> evenNumbers = ints => ints.Where(n => n % 2 == 0).OrderBy(x=>x).ToList();
            Console.WriteLine(string.Join(", ", evenNumbers(numbers)));
        }
    }
}
