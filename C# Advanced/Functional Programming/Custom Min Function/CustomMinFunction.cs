namespace Custom_Min_Function
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomMinFunction
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();
            Func<List<int>, int> smallestNum = ints => ints.Min();
            Console.WriteLine(smallestNum(numbers));
        }
    }
}
