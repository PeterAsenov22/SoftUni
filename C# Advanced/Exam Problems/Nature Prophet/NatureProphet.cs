namespace Nature_Prophet
{
    using System;
    using System.Linq;

    public class NatureProphet
    {
        public static void Main()
        {
            var matrixParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var rows = matrixParams[0];
            var cols = matrixParams[1];
            var matrix = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];
            }

            var input = Console.ReadLine();
            while (input!="Bloom Bloom Plow")
            {
                var inputParams = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();
                var rowToPlant = inputParams[0];
                var colToPlant = inputParams[1];
                matrix[rowToPlant][colToPlant]++;
                for (int i = 0; i < cols; i++)
                {
                    if (i != colToPlant)
                    {
                        matrix[rowToPlant][i]++;
                    }
                }

                for (int i = 0; i < rows; i++)
                {
                    if (i != rowToPlant)
                    {
                        matrix[i][colToPlant]++;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
