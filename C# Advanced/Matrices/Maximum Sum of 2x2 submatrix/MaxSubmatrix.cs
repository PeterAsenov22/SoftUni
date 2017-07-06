namespace Maximum_Sum_of_2x2_submatrix
{
    using System;
    using System.Linq;

    public class MaxSubmatrix
    {
        public static void Main()
        {
            var matrixParams = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var rows = matrixParams[0];
            var cols = matrixParams[1];
            var matrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }

            var maxSum = int.MinValue;
            var maxElRows = int.MinValue;
            var maxElCols = int.MinValue;

            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < cols-1; j++)
                {
                    var currSum = matrix[i][j] + matrix[i][j + 1] + matrix[i + 1][j] + matrix[i + 1][j + 1];

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxElRows = i;
                        maxElCols = j;
                    }
                }
            }

            Console.WriteLine(matrix[maxElRows][maxElCols] + " " + matrix[maxElRows][maxElCols+1]);
            Console.WriteLine(matrix[maxElRows+1][maxElCols] + " " + matrix[maxElRows+1][maxElCols + 1]);
            Console.WriteLine(maxSum);
        }
    }
}
