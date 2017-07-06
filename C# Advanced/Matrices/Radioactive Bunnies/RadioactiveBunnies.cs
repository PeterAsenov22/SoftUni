namespace Radioactive_Bunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RadioactiveBunnies
    {
        public static void Main()
        {
            var matrixParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
           
            var rows = matrixParams[0];
            var cols = matrixParams[1];
            var matrix = new char[rows][];
            var playerRow = 0;
            var playerCol = 0;
            var bunnies = new Queue<int[]>();
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
                if (matrix[i].Contains('P'))
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] == 'P')
                        {
                            playerRow = i;
                            playerCol = j;
                            matrix[i][j] = '.';
                        }
                    }
                }

                if (matrix[i].Contains('B'))
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (matrix[i][j] == 'B')
                        {
                            var bunny = new int[2];
                            bunny[0] = i;
                            bunny[1] = j;

                            bunnies.Enqueue(bunny);
                        }
                    }
                }
            }

            var commands = Console.ReadLine().ToCharArray();
            var isDead = false;
            var won = false;

            for (int i = 0; i < commands.Length; i++)
            {
                var currentCommand = commands[i];
                if (currentCommand == 'L')
                {
                    if (playerCol - 1 >= 0)
                    {
                        if (matrix[playerRow][playerCol - 1] == 'B')
                        {
                            isDead = true;
                        }
                        playerCol--;
                    }
                    else
                    {
                        won = true;
                    }
                }
                else if (currentCommand == 'U')
                {
                    if (playerRow - 1 >= 0)
                    {
                        if (matrix[playerRow-1][playerCol] == 'B')
                        {
                            isDead = true;
                        }
                        playerRow--;
                    }
                    else
                    {
                        won = true;
                    }
                }
                else if (currentCommand == 'R')
                {
                    if (playerCol + 1 <= cols-1)
                    {
                        if (matrix[playerRow][playerCol + 1] == 'B')
                        {
                            isDead = true;
                        }                       
                            playerCol++;             
                    }
                    else
                    {
                        won = true;
                    }
                }
                else
                {
                    if (playerRow + 1 <= rows - 1)
                    {
                        if (matrix[playerRow+1][playerCol] == 'B')
                        {
                            isDead = true;
                        }
                        playerRow++;
                    }
                    else
                    {
                        won = true;
                    }
                }

                var bunnyCount = bunnies.Count;
                for (int j = 0; j < bunnyCount; j++)
                {
                    var currentBunny = bunnies.Dequeue();
                    var bunnyRow = currentBunny[0];
                    var bunnyCol = currentBunny[1];

                    if (bunnyCol - 1 >= 0)
                    {
                        if (matrix[bunnyRow][bunnyCol - 1] != 'B')
                        {                           
                            matrix[bunnyRow][bunnyCol - 1] = 'B';
                            if (!isDead && !won)
                            {
                                if (bunnyRow == playerRow && bunnyCol - 1 == playerCol)
                                {
                                    isDead = true;
                                }
                            }
                            var newBunny = new int[2];
                            newBunny[0] = bunnyRow;
                            newBunny[1] = bunnyCol - 1;
                            bunnies.Enqueue(newBunny);
                        }
                    }

                    if (bunnyCol + 1 <= cols-1)
                    {
                        if (matrix[bunnyRow][bunnyCol + 1] != 'B')
                        {
                            matrix[bunnyRow][bunnyCol + 1] = 'B';
                            if (!isDead && !won)
                            {
                                if (bunnyRow == playerRow && bunnyCol + 1 == playerCol)
                                {
                                    isDead = true;
                                }
                            }
                            var newBunny = new int[2];
                            newBunny[0] = bunnyRow;
                            newBunny[1] = bunnyCol + 1;
                            bunnies.Enqueue(newBunny);
                        }
                    }

                    if (bunnyRow - 1 >= 0)
                    {
                        if (matrix[bunnyRow-1][bunnyCol] != 'B')
                        {
                            matrix[bunnyRow-1][bunnyCol] = 'B';
                            if (!isDead && !won)
                            {
                                if (bunnyRow - 1 == playerRow && bunnyCol == playerCol)
                                {
                                    isDead = true;
                                }
                            }                            
                            var newBunny = new int[2];
                            newBunny[0] = bunnyRow-1;
                            newBunny[1] = bunnyCol;
                            bunnies.Enqueue(newBunny);
                        }
                    }

                    if (bunnyRow + 1 <= rows - 1)
                    {
                        if (matrix[bunnyRow + 1][bunnyCol] != 'B')
                        {
                            matrix[bunnyRow + 1][bunnyCol] = 'B';
                            if (!isDead && !won)
                            {
                                if (bunnyRow + 1 == playerRow && bunnyCol == playerCol)
                                {
                                    isDead = true;
                                }
                            }
                            var newBunny = new int[2];
                            newBunny[0] = bunnyRow + 1;
                            newBunny[1] = bunnyCol;
                            bunnies.Enqueue(newBunny);
                        }
                    }
                }

                if (isDead || won)
                {
                    break;
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join("",matrix[i]));
            }

            if (isDead)
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
            else if (won)
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
        }
    }
}
