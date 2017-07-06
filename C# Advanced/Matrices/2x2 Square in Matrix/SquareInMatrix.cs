namespace _2x2_Square_in_Matrix
{
    using System;
    using System.Linq;

    public class SquareInMatrix
    {
        public static void Main()
        {
            var matrixParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var rows = matrixParams[0];
            var cols = matrixParams[1];
            var matrix = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).ToArray();
            }

            var count = 0;
            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < cols-1; j++)
                {
                    if (matrix[i][j] == matrix[i][j + 1] && matrix[i + 1][j] == matrix[i][j] &&
                        matrix[i][j] == matrix[i + 1][j + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
