namespace Parking_System
{
    using System;
    using System.Linq;

    public class ParkingSystem
    {
        public static void Main()
        {
            var parkingParams = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var rows = parkingParams[0];
            var cols = parkingParams[1];
            var parking = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                parking[i] = new int[cols];
                parking[i][0] = 1;
            }

            var command = Console.ReadLine();
            while (command != "stop")
            {
                var commmandParams = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();
                var startingRow = commmandParams[0];
                var desiredRow = commmandParams[1];
                var desiredCol = commmandParams[2];
                var distance = Math.Abs(desiredRow - startingRow) + 1;

                if (parking[desiredRow].All(x => x == 1))
                {
                    Console.WriteLine($"Row {desiredRow} full");
                }
                else
                {
                    if (parking[desiredRow][desiredCol] !=1)
                    {
                        parking[desiredRow][desiredCol] = 1;
                        distance += desiredCol;
                        Console.WriteLine(distance);
                    }
                    else
                    {
                        var freeToTheLeft = 0;
                        var freeToTheRight = 0;

                        for (int i = desiredCol - 1; i > 0; i--)
                        {
                            if (parking[desiredRow][i] != 1)
                            {
                                freeToTheLeft = i;
                                break;
                            }
                        }

                        for (int i = desiredCol + 1; i < cols; i++)
                        {
                            if (parking[desiredRow][i] !=1)
                            {
                                freeToTheRight = i;
                                break;
                            }
                        }

                        if (freeToTheLeft == 0)
                        {
                            parking[desiredRow][freeToTheRight] = 1;
                            distance += freeToTheRight;
                            Console.WriteLine(distance);
                        }
                        else if (freeToTheRight == 0)
                        {
                            parking[desiredRow][freeToTheLeft] = 1;
                            distance += freeToTheLeft;
                            Console.WriteLine(distance);
                        }
                        else
                        {
                            if (desiredCol - freeToTheLeft <= freeToTheRight - desiredCol)
                            {
                                parking[desiredRow][freeToTheLeft] = 1;
                                distance += freeToTheLeft;
                                Console.WriteLine(distance);
                            }
                            else
                            {
                                parking[desiredRow][freeToTheRight] = 1;
                                distance += freeToTheRight;
                                Console.WriteLine(distance);
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
