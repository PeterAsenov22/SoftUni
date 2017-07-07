namespace Hot_Potato
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HotPotato
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var queue = new Queue<string>(input);
            var n = int.Parse(Console.ReadLine());

            while(queue.Count>1)
            {
                for (int i = 1; i < n; i++)
                {
                    var curr = queue.Dequeue();
                    queue.Enqueue(curr);
                }

                var removed = queue.Dequeue();
                Console.WriteLine($"Removed {removed}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
