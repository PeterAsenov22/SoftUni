namespace Cubics_Rube
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class CubicsRube
    {
        public static void Main()
        {
            var dimensions = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            BigInteger particles = 0;
            var shotCount = 0;
            while (input != "Analyze")
            {
                var inputParams = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(BigInteger.Parse)
                    .ToArray();


                if (inputParams[0] >= 0 && inputParams[0] < dimensions
                    && inputParams[1] >= 0 && inputParams[1] < dimensions
                    && inputParams[2] >= 0 && inputParams[2] < dimensions)
                {
                    if (inputParams[3] != 0)
                    {
                        particles += inputParams[3];
                        shotCount++;
                    }
                }


                input = Console.ReadLine();
            }

            Console.WriteLine(particles);
            Console.WriteLine((BigInteger.Pow(dimensions, 3)) - shotCount);
        }
    }
}


