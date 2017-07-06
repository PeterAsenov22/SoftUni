namespace Diagonal_Difference
{
    using System;
    using System.Linq;

    public class DiagonalDifference
    {
        public static void Main()
        {
            var matrixParams = int.Parse(Console.ReadLine());
            var matrix = new int[matrixParams][];

            for (int i = 0; i < matrixParams; i++)
            {
                matrix[i] = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }

            var primaryDiagonalSum = 0;
            var secondaryDiagonalSum = 0;
            var primaryIndex = 0;
            var secondaryIndex = matrixParams-1;

            for (int i = 0; i < matrixParams; i++)
            {
                primaryDiagonalSum += matrix[i][primaryIndex];
                secondaryDiagonalSum += matrix[i][secondaryIndex];
                primaryIndex++;
                secondaryIndex--;
            }

            Console.WriteLine(Math.Abs(primaryDiagonalSum-secondaryDiagonalSum));
        }
    }
}
