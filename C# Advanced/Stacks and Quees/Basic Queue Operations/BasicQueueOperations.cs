namespace Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicQueueOperations
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var N = input[0];
            var S = input[1];
            var X = input[2];

            var queue = new Queue<int>(numbers);

            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();

                if (queue.Count == 0)
                {
                    break;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (queue.Contains(X))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
