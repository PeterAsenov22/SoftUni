namespace Target_Practice
{
    using System;
    using System.Linq;

    public class TargetPractice
    {
        public static void Main()
        {
            var matrixParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var rows = matrixParams[0];
            var cols = matrixParams[1];
            var matrix = new char[rows][];
            var text = Console.ReadLine();
            var index = 0;
            var rowsCount = 0;
            for (int i = rows-1; i >= 0; i--)
            {
                matrix[i] = new char[cols];
                if (rowsCount % 2 == 0)
                {
                    for (int j = cols-1; j >= 0; j--)
                    {
                        matrix[i][j] = text[index % text.Length];
                        index++;
                    }
                }
                else
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i][j] = text[index % text.Length];
                        index++;
                    }
                }

                rowsCount++;
            }

            var shotParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var shotRow = shotParams[0];
            var shotCol = shotParams[1];
            var radius = shotParams[2];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    var distance = Math.Sqrt(Math.Pow(j-shotCol,2) + Math.Pow(i-shotRow,2));
                    if (distance <= radius)
                    {
                        matrix[i][j] = ' ';
                    }
                }
            }

            for (int i = rows - 1; i > 0; i--)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] == ' ')
                    {
                        for (int k = i-1; k >= 0; k--)
                        {
                            if (matrix[k][j] != ' ')
                            {
                                matrix[i][j] = matrix[k][j];
                                matrix[k][j] = ' ';
                                break;
                            }
                        }
                    }
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("",row));
            }
        }
    }
}
