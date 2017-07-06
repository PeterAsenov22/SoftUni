namespace Lego_Blocks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LegoBlocks
    {
        public static void Main()
        {
            var rowsParam = Console.ReadLine();
            var rows = int.Parse(rowsParam.Trim());
            var firstMatrix = new int[rows][];
            var secondMatrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                firstMatrix[i] = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim()).Select(int.Parse).ToArray();
            }

            for (int i = 0; i < rows; i++)
            {
                secondMatrix[i] = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim()).Select(int.Parse).ToArray();
            }

            var newMatrix = new int[rows][];
            var expectedCols = firstMatrix[0].Length + secondMatrix[0].Length;
            var totalCells = 0;
            var colsCount = new HashSet<int>();
            for (int i = 0; i < rows; i++)
            {                
                var newRow = firstMatrix[i].Concat(secondMatrix[i].Reverse()).ToArray();
                newMatrix[i] = newRow;
                totalCells += newRow.Length;
                colsCount.Add(newRow.Length);
            }

            if (colsCount.Count != 1)
            {
                Console.WriteLine($"The total number of cells is: {totalCells}");
            }
            else
            {
                foreach (var row in newMatrix)
                {
                    Console.WriteLine($"[{string.Join(", ", row)}]");
                }
            }
        }
    }
}
