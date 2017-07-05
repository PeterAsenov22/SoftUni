namespace Bounded_Numbers
{
    using System;
    using System.Linq;

    public class BoundedNumbers
    {
        public static void Main()
        {
            var boundersParams = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x=>x).ToArray();
            var lowerBound = boundersParams[0];
            var upperBound = boundersParams[1];
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).Where(x => x >= lowerBound && x <= upperBound)
                .ToArray();
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
