namespace List_Of_Predicates
{
    using System;
    using System.Linq;

    public class ListOfPredicates
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).Distinct().ToList();
            Func<int, int, bool> predicate = (i, m) => i % m == 0;

            for (int i = 1; i <= n; i++)
            {
                var isCurrNumDivisible = true;
                for (int j = 0; j < dividers.Count; j++)
                {
                    var currDivider = dividers[j];
                    if (!predicate(i, currDivider))
                    {
                        isCurrNumDivisible = false;
                        break;
                    }
                }

                if (isCurrNumDivisible)
                {
                    Console.Write(i+" ");
                }
            }

            Console.WriteLine();
        }
    }
}
