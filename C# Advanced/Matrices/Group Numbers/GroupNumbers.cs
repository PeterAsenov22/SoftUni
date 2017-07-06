namespace Group_Numbers
{
    using System;
    using System.Linq;

    public class GroupNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            var sizes = new int[3];

            foreach (var number in numbers)
            {
                int reminder = Math.Abs(number % 3);
                sizes[reminder]++;
            }
            var matrix = new int[3][]
            {
                new int[sizes[0]],
                new int[sizes[1]],
                new int[sizes[2]]
            };

            var offset = new int[3];
            foreach (var number in numbers)
            {
                int reminder = Math.Abs(number % 3);
                var index = offset[reminder];
                offset[reminder]++;
                matrix[reminder][index] = number;
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
