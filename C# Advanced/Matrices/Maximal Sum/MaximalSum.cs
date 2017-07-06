namespace Maximal_Sum
{
    using System;
    using System.Linq;

    public class MaximalSum
    {
        public static void Main()
        {
            var matrixParams = Console.ReadLine().Split(new [] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rows = matrixParams[0];
            var cols = matrixParams[1];
            var matrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            var maxSum = int.MinValue;
            var maxElRow = int.MinValue;
            var maxElCol = int.MinValue;

            for (int i = 0; i < matrix.Length-2; i++)
            {
                for (int j = 0; j < cols-2; j++)
                {
                    var currSum = matrix[i][j] + matrix[i][j + 1] + matrix[i][j+2] + matrix[i+1][j + 1] + matrix[i+1][j] +
                                  matrix[i+1][j + 2] + matrix[i+2][j] + matrix[i+2][j + 1] + matrix[i+2][j+2];

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxElRow = i;
                        maxElCol = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[maxElRow][maxElCol]} {matrix[maxElRow][maxElCol+1]} {matrix[maxElRow][maxElCol+2]}");
            Console.WriteLine($"{matrix[maxElRow+1][maxElCol]} {matrix[maxElRow+1][maxElCol + 1]} {matrix[maxElRow+1][maxElCol + 2]}");
            Console.WriteLine($"{matrix[maxElRow+2][maxElCol]} {matrix[maxElRow+2][maxElCol + 1]} {matrix[maxElRow+2][maxElCol + 2]}");
        }
    }
}
