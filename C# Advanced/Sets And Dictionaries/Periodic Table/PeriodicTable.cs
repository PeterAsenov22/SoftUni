namespace Periodic_Table
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PeriodicTable
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var compounds = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var inputParams = Console.ReadLine().Split();

                foreach (var element in inputParams)
                {
                    compounds.Add(element);
                }
            }
           
            Console.WriteLine(string.Join(" ",compounds));
        }
    }
}
