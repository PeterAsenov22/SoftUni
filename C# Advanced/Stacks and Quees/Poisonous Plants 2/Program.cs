namespace Poisonous_Plants_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse)
                .ToArray();
            var queue = new Queue<long>(plants.Reverse());
            var days = 0;

            while (true)
            {
                var currCount = queue.Count;
                
                for (int i = 0; i < currCount-1; i++)
                {
                    var currPlant = queue.Dequeue();
                    if (currPlant <= queue.Peek())
                    {
                        queue.Enqueue(currPlant);
                    }
                }

                var last = queue.Dequeue();
                queue.Enqueue(last);

                if (currCount == queue.Count)
                {
                    break;
                }
                else
                {
                    days++;
                }
            }

            Console.WriteLine(days);
        }
    }
}
