namespace Pascal_Triangle
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class PascalTriangle
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine(1);
            }
            else
            {

                var matrix = new BigInteger[input][];
                matrix[0] = new BigInteger[1];
                matrix[1] = new BigInteger[2];
                matrix[0][0] = 1;
                matrix[1][0] = 1;
                matrix[1][1] = 1;

                for (int i = 2; i < input; i++)
                {
                    var list = new List<BigInteger>();
                    list.Add(1);
                    for (int j = 0; j < matrix[i - 1].Length - 1; j++)
                    {
                        BigInteger currEl = matrix[i - 1][j] + matrix[i - 1][j + 1];
                        list.Add(currEl);
                    }
                    list.Add(1);
                    matrix[i] = new BigInteger[list.Count];
                    matrix[i] = list.ToArray();
                }

                foreach (var row in matrix)
                {
                    Console.WriteLine(string.Join(" ", row));
                }
            }
        }
    }
}
