namespace Target_Practice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TargetPractice
    {
        public static void Main()
        {
            var matrixParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var snake = Console.ReadLine().ToCharArray();
            var shotParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var rows = matrixParams[0];
            var cols = matrixParams[1];
            var matrix = new char[rows][];
            var currentIndex = 0;
            var rowsCount = 1;

            for (int i = rows-1; i >=0; i--)
            {
                
                var rowToAdd = new char[cols];
                for (int j = 0; j < cols; j++)
                {
                    rowToAdd[j] = snake[currentIndex % snake.Length];
                    currentIndex++;
                }

                if (rowsCount % 2 != 0)
                {
                    matrix[i] = rowToAdd.Reverse().ToArray();
                }
                else
                {
                    matrix[i] = rowToAdd;
                }

                rowsCount++;
            }
            
            var shotRow = shotParams[0];
            var shotCol = shotParams[1];
            var radius = shotParams[2];

            if (radius == 0)
            {
                matrix[shotRow][shotCol] = ' ';
            }
            else
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        var currX = i;
                        var currY = j;
                        var distance = Math.Sqrt((shotRow - currX) * (shotRow - currX) +
                                                 (shotCol - currY) * (shotCol - currY));
                        if (distance <= radius)
                        {
                            matrix[i][j] = ' ';
                        }
                    }
                }
            }

            for (int i = 0; i < cols; i++)
            {
                var column = i;
                var queue = new Queue<char>();
                for (int j = rows - 1; j >= 0; j--)
                {
                    if (matrix[j][column] != ' ')
                    {
                        queue.Enqueue(matrix[j][column]);
                    }
                }
                
                for (int j = rows - 1; j >= 0; j--)
                {
                    if (queue.Count > 0)
                    {
                        matrix[j][column] = queue.Dequeue();
                    }
                    else
                    {
                        matrix[j][column] = ' ';
                    }
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}
