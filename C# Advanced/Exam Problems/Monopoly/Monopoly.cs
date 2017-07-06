namespace Monopoly
{
    using System;
    using System.Linq;

    public class Monopoly
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
                matrix[i] = Console.ReadLine().ToCharArray();
            }

            var money = 50;
            var hotels = 0;
            var turns = 0;

            for (int i = 0; i < rows; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (matrix[i][j] == 'H')
                        {
                            hotels++;
                            Console.WriteLine($"Bought a hotel for {money}. Total hotels: {hotels}.");
                            money = 0;
                            money = hotels * 10;
                            turns++;
                        }
                        else if (matrix[i][j] == 'J')
                        {
                            Console.WriteLine($"Gone to jail at turn {turns}.");
                            turns += 3;
                            money += hotels * 10 * 3;
                        }
                        else if(matrix[i][j] == 'F')
                        {
                            turns++;
                            money += hotels * 10;
                        }
                        else if (matrix[i][j] == 'S')
                        {
                            var spent = (i + 1) * (j + 1);
                            if (spent > money)
                            {
                                spent = money;
                            }

                            Console.WriteLine($"Spent {spent} money at the shop.");
                            money -= spent;
                            turns++;
                            money += hotels * 10;
                        }
                    }
                }
                else
                {
                    for (int j = cols-1; j >=0; j--)
                    {
                        if (matrix[i][j] == 'H')
                        {
                            hotels++;
                            Console.WriteLine($"Bought a hotel for {money}. Total hotels: {hotels}.");
                            money = 0;
                            money = hotels * 10;
                            turns++;
                        }
                        else if (matrix[i][j] == 'J')
                        {
                            Console.WriteLine($"Gone to jail at turn {turns}.");
                            turns += 3;
                            money += hotels * 10 * 3;
                        }
                        else if (matrix[i][j] == 'F')
                        {
                            turns++;
                            money += hotels * 10;
                        }
                        else if (matrix[i][j] == 'S')
                        {
                            var spent = (i + 1) * (j + 1);
                            if (spent > money)
                            {
                                spent = money;
                            }

                            Console.WriteLine($"Spent {spent} money at the shop.");
                            money -= spent;
                            turns++;
                            money += hotels * 10;
                        }
                    }
                }
            }

            Console.WriteLine($"Turns {turns}");
            Console.WriteLine($"Money {money}");
        }
    }
}
