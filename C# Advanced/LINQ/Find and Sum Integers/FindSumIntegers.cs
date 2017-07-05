namespace Find_and_Sum_Integers
{
    using System;
    using System.Linq;

    public class FindSumIntegers
    {
        public static void Main()
        {
            long sum ;
            var numbers = Console.ReadLine().Split(' ').Where(x=>long.TryParse(x,out sum));

            if (numbers.Count() == 0)
            {
                Console.WriteLine("No match");
            }
            else
            {
                Console.WriteLine(numbers.Select(long.Parse).Sum());
            }
        }
    }
}
