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
            var parkingRows = parkingParams[0];
            var parkingCols = parkingParams[1];
            var parking = new int[parkingRows][];

            for (int i = 0; i < parkingRows; i++)
            {
                parking[i] = new int[parkingCols];
                parking[i][0] = 1;
            }

            var command = Console.ReadLine();
            while (command != "stop")
            {
                var commandParams = command.Split(' ').Select(int.Parse).ToArray();
                var startingRow = commandParams[0];
                var desiredRow = commandParams[1];
                var desiredCol = commandParams[2];

                var distanceToDesiredSpot = 1 + Math.Abs(desiredRow - startingRow);

                if (parking[desiredRow].All(x => x == 1))
                {
                    Console.WriteLine($"Row {desiredRow} full");
                }
                else
                {
                    if (parking[desiredRow][desiredCol] != 1)
                    {
                        parking[desiredRow][desiredCol] = 1;
                        distanceToDesiredSpot += desiredCol;
                        Console.WriteLine(distanceToDesiredSpot);
                    }
                    else
                    {
                        int firstFound = 0;
                        int secondFound = 0;

                        for (int i = desiredCol - 1; i > 0; i--)
                        {
                            if (parking[desiredRow][i] != 1)
                            {
                                firstFound = i;
                                break;
                            }
                        }



                        for (int i = desiredCol + 1; i < parkingCols; i++)
                        {
                            if (parking[desiredRow][i] != 1)
                            {
                                secondFound = i;
                                break;
                            }
                        }

                        if (firstFound == 0)
                        {
                            parking[desiredRow][secondFound] = 1;
                            distanceToDesiredSpot += secondFound;
                            Console.WriteLine(distanceToDesiredSpot);
                        }
                        else if(secondFound == 0)
                        {
                            parking[desiredRow][firstFound] = 1;
                            distanceToDesiredSpot += firstFound;
                            Console.WriteLine(distanceToDesiredSpot);
                        }
                        else
                        {
                            if ((desiredCol - firstFound) > (secondFound - desiredCol))
                            {
                                parking[desiredRow][secondFound] = 1;
                                distanceToDesiredSpot += secondFound;
                                Console.WriteLine(distanceToDesiredSpot);
                            }
                            else
                            {
                                parking[desiredRow][firstFound] = 1;
                                distanceToDesiredSpot += firstFound;
                                Console.WriteLine(distanceToDesiredSpot);
                            }                           
                        }
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
