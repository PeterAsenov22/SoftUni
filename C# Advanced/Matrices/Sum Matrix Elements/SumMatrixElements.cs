namespace Sum_Matrix_Elements
{
    using System;
    using System.Linq;

    public class SumMatrixElements
    {
        public static void Main()
        {
            var matrixParams = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rows = matrixParams[0];
            var colums = matrixParams[1];
            var matrix = new int[rows][];
            var sum = 0;

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                sum += matrix[i].Sum();
            }

            Console.WriteLine(matrix.Length);
            Console.WriteLine(matrix[0].Length);
            Console.WriteLine(sum);
        }
    }
}
