namespace Set_of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SetOfElements
    {
        public static void Main()
        {
            var inputParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = inputParams[0];
            int m = inputParams[1];

            var setN = new HashSet<int>();
            var setM = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                setN.Add(input);
            }

            for (int i = 0; i < m; i++)
            {
                var input = int.Parse(Console.ReadLine());
                setM.Add(input);
            }

            var containing = new HashSet<int>();

            foreach (var num in setN)
            {
                if (setM.Contains(num))
                {
                    containing.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ",containing));
        }
    }
}
