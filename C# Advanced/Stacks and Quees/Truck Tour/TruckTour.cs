namespace Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TruckTour
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            var pumps = new Queue<PetrolPump>();

            for (int i = 0; i < n; i++)
            {
                var inputParams = Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
                var pump = new PetrolPump
                {
                    Fuel = inputParams[0],
                    KmToNextStation = inputParams[1],
                    PumpIndex = i
                };

                pumps.Enqueue(pump);               
            }

            PetrolPump starterPump = null;
            var completeJourney = false;

            while (true)
            {
                var currentPump = pumps.Dequeue();
                pumps.Enqueue(currentPump);
                starterPump = currentPump;
                var petrolInTank = currentPump.Fuel;

                while (petrolInTank>=currentPump.KmToNextStation)
                {
                    petrolInTank -= currentPump.KmToNextStation;

                    currentPump = pumps.Dequeue();
                    pumps.Enqueue(currentPump);

                    if(currentPump == starterPump)
                    {
                        completeJourney = true;
                        break;
                    }

                    petrolInTank += currentPump.Fuel;
                }

                if(completeJourney)
                {
                    Console.WriteLine(starterPump.PumpIndex);
                    break;
                }
            }           
        }
    }
}
