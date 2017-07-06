namespace Crossfire
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Crossfire
    {
        public static void Main()
        {
            var matrixParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToArray();
            var rows = matrixParams[0];
            var cols = matrixParams[1];
            var matrix = new long[rows][];
            var num = 1;

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new long[cols];
                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = num;
                    num++;
                }
            }
            
            var command = Console.ReadLine();
            while (command != "Nuke it from orbit")
            {
                var commandParams = command.Split(' ');
                var shotRow = long.Parse(commandParams[0]);
                var shotCol = long.Parse(commandParams[1]);
                var radius = long.Parse(commandParams[2]);
                
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        for (int j = 0; j < matrix[i].Length; j++)
                        {
                            var currX = i;
                            var currY = j;
                            var distance = Math.Sqrt((shotRow - currX) * (shotRow - currX) +
                                                     (shotCol - currY) * (shotCol - currY));
                            if (distance <= radius)
                            {
                                if (currX == shotRow || currY == shotCol)
                                {
                                    matrix[i][j] = -1;
                                }
                            }
                        }
                    }
                
                for (int i = 0; i < matrix.Length; i++)
                {
                    if (matrix[i].Contains(-1))
                    {
                        List<long> newArray = matrix[i].ToList();
                        newArray.RemoveAll(x => x == -1);

                        matrix[i] = newArray.ToArray();
                    }

                    if (matrix[i].Length < 1)
                    {
                        matrix = matrix.Take(i).Concat(matrix.Skip(i + 1)).ToArray();
                        i--;
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var row in matrix)
            {
                    Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
