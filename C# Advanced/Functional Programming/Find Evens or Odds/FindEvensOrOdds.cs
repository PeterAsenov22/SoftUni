namespace Find_Evens_or_Odds
{
    using System;
    using System.Linq;

    public class FindEvensOrOdds
    {
        public static void Main()
        {
            var inputParams = Console.ReadLine().Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var condition = Console.ReadLine();

            var lowerBound = inputParams[0];
            var upperBound = inputParams[1];
            Predicate<int> predicate = i => i % 2 == 0;

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (condition == "odd")
                {
                    if (!predicate(i))
                    {
                        Console.Write(i + " ");
                    }
                }
                else
                {
                    if (predicate(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
