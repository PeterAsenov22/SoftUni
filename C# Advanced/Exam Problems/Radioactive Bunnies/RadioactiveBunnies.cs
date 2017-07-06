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
            var currentNewBunnies = new List<string>();
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
                if (matrix[i].Contains('B') || matrix[i].Contains('P'))
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (matrix[i][j] == 'B')
                        {
                            var bunnyCoord = $"{i},{j}";
                            currentNewBunnies.Add(bunnyCoord);
                        }

                        if (matrix[i][j] == 'P')
                        {
                            playerRow = i;
                            playerCol = j;
                            matrix[i][j] = '.';
                        }
                    }
                }
            }

            var moves = Console.ReadLine();
            var hasLost = false;
            var hasWon = false;
            for (int i = 0; i < moves.Length; i++)
            {
                var currentMove = moves[i];
                if (currentMove == 'L')
                {
                    playerCol--;
                    if (playerCol < 0)
                    {
                        hasWon = true;
                        playerCol++;
                    }
                }
                else if(currentMove == 'R')
                {
                    playerCol++;
                    if (playerCol == cols)
                    {
                        hasWon = true;
                        playerCol--;
                    }
                }
                else if (currentMove == 'U')
                {
                    playerRow--;
                    if (playerRow < 0)
                    {
                        hasWon = true;
                        playerRow++;
                    }
                }
                else
                {
                    playerRow++;
                    if (playerRow == rows)
                    {
                        hasWon = true;
                        playerRow--;
                    }
                }

                if (matrix[playerRow][playerCol] == 'B')
                {
                    hasLost = true;
                }

                var newBunnies = new List<string>();
                for (int j = 0; j < currentNewBunnies.Count; j++)
                {
                    var currentBunnyParams = currentNewBunnies[j].Split(',').Select(int.Parse).ToArray();
                    var bunnyRow = currentBunnyParams[0];
                    var bunnyCol = currentBunnyParams[1];

                    if (bunnyCol - 1 >= 0)
                    {
                        if (matrix[bunnyRow][bunnyCol - 1] == '.')
                        {
                            matrix[bunnyRow][bunnyCol - 1] = 'B';
                            newBunnies.Add($"{bunnyRow},{bunnyCol-1}");
                        }

                        if (!hasWon)
                        {
                            if (bunnyRow == playerRow && bunnyCol - 1 == playerCol)
                            {
                                hasLost = true;
                            }
                        }
                    }

                    if (bunnyCol + 1 < cols)
                    {
                        if (matrix[bunnyRow][bunnyCol + 1] == '.')
                        {
                            matrix[bunnyRow][bunnyCol + 1] = 'B';
                            newBunnies.Add($"{bunnyRow},{bunnyCol + 1}");
                        }
                        if (!hasWon)
                        {
                            if (bunnyRow == playerRow && bunnyCol + 1 == playerCol)
                            {
                                hasLost = true;
                            }
                        }
                    }

                    if (bunnyRow - 1 >= 0)
                    {
                        if (matrix[bunnyRow - 1][bunnyCol] == '.')
                        {
                            matrix[bunnyRow - 1][bunnyCol] = 'B';
                            newBunnies.Add($"{bunnyRow - 1},{bunnyCol}");
                        }
                        if (!hasWon)
                        {
                            if (bunnyRow - 1 == playerRow && bunnyCol == playerCol)
                            {
                                hasLost = true;
                            }
                        }
                    }

                    if (bunnyRow + 1 < rows)
                    {
                        if (matrix[bunnyRow + 1][bunnyCol] == '.')
                        {
                            matrix[bunnyRow + 1][bunnyCol] = 'B';
                            newBunnies.Add($"{bunnyRow + 1},{bunnyCol}");
                        }

                        if (!hasWon)
                        {
                            if (bunnyRow + 1 == playerRow && bunnyCol == playerCol)
                            {
                                hasLost = true;
                            }
                        }
                    }              
                }

                currentNewBunnies.Clear();
                currentNewBunnies = newBunnies;

                if (hasWon || hasLost)
                {
                    foreach (var row in matrix)
                    {
                        Console.WriteLine(string.Join("",row));
                    }

                    if (hasLost)
                    {
                        Console.WriteLine($"dead: {playerRow} {playerCol}");
                    }
                    else
                    {
                        Console.WriteLine($"won: {playerRow} {playerCol}");
                    }

                    break;
                }
            }
        }
    }
}
