namespace Math_Potato
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MathPotato
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var queue = new Queue<string>(input);
            var n = int.Parse(Console.ReadLine());
            var cycle = 1;
            while (queue.Count > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    var curr = queue.Dequeue();
                    queue.Enqueue(curr);
                }

                if (isPrime(cycle))
                {
                    Console.WriteLine($"Prime {queue.Peek()}");
                }
                else
                {
                    var removed = queue.Dequeue();
                    Console.WriteLine($"Removed {removed}");
                }

                cycle++;
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
        public static bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
