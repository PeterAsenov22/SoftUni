namespace Rubik_s_Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RubiksMatrix
    {
        public static void Main()
        {
            var matrixParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var commandsCount = int.Parse(Console.ReadLine());
            var rows = matrixParams[0];
            var cols = matrixParams[1];
            var matrix = new int[rows][];
            var fillingNumber = 1;

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = fillingNumber;
                    fillingNumber++;
                }
            }

            for (int i = 0; i < commandsCount; i++)
            {
                var command = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command[1] == "up" || command[1] == "down")
                {
                    var column = int.Parse(command[0]);
                    var moves = int.Parse(command[2]) % rows;

                    if (moves != rows)
                    {
                        var queue = new Queue<int>();
                        
                        if (command[1] == "down")
                        {
                            for (int j = rows - 1; j >= 0; j--)
                            {
                                queue.Enqueue(matrix[j][column]);
                            }

                            for (int j = 0; j < moves; j++)
                            {
                                queue.Enqueue(queue.Dequeue());
                            }

                            for (int j = rows - 1; j >= 0; j--)
                            {
                                matrix[j][column] = queue.Dequeue();
                            }
                        }
                        else
                        {
                            for (int j = 0; j<rows; j++)
                            {
                                queue.Enqueue(matrix[j][column]);
                            }

                            for (int j = 0; j < moves; j++)
                            {
                                queue.Enqueue(queue.Dequeue());
                            }

                            for (int j = 0; j < rows; j++)
                            {
                                matrix[j][column] = queue.Dequeue();
                            }
                        }
                    }

                }
                else
                {
                    var row = int.Parse(command[0]);
                    var moves = int.Parse(command[2]) % cols;

                    if (command[1] == "right")
                    {
                        if (moves != cols)
                        {
                            var newRow = new int[cols];
                            for (int j = 0; j < cols; j++)
                            {
                                var currNewIndex = (j + moves) % cols;
                                newRow[currNewIndex] = matrix[row][j];
                            }

                            matrix[row] = newRow;
                        }
                    }
                    else
                    {
                        if (moves != cols)
                        {
                            var newRow = new int[cols];
                            for (int j = 0; j < cols; j++)
                            {
                                var currNewIndex =0;
                                if (j - moves < 0)
                                {
                                    currNewIndex = cols - (Math.Abs(j - moves));
                                }
                                else
                                {
                                    currNewIndex = j - moves;
                                }
                                newRow[currNewIndex] = matrix[row][j];
                            }

                            matrix[row] = newRow;
                        }
                    }
                }
            }

            var expectedNum = 1;
            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                for (int currentCol = 0; currentCol < cols; currentCol++)
                {
                    if (matrix[currentRow][currentCol] == expectedNum)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        var elemToSwap = matrix[currentRow][currentCol];
                        for (int i = currentRow; i < rows; i++)
                        {
                            for (int j = 0; j < cols; j++)
                            {
                                var currElem = matrix[i][j];
                                if (currElem == expectedNum)
                                {
                                    Console.WriteLine($"Swap ({currentRow}, {currentCol}) with ({i}, {j})");
                                    matrix[currentRow][currentCol] = expectedNum;
                                    matrix[i][j] = elemToSwap;
                                }
                            }
                        }
                    }
                    expectedNum++;
                }
            }
        }
    }
}