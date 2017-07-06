namespace Sum_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Func<List<int>, int> sum = ints => ints.Sum();
            Func<List<int>, int> count = ints => ints.Count;
            Console.WriteLine(count(numbers));
            Console.WriteLine(sum(numbers));
        }
    }
}
