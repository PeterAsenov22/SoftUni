namespace Second_Nature
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SecondNature
    {
        public static void Main()
        {
            var flowersParams = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).Reverse().ToArray();
            var bucketsParams = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var flowers = new Stack<int>(flowersParams);
            var buckets = new Stack<int>(bucketsParams);
            var secondNature = new List<int>();
            var savedWater = 0;

            while (flowers.Count > 0 && buckets.Count > 0)
            {
                var currWater = buckets.Peek();
                var currFlower = flowers.Peek();

                if (currFlower == currWater)
                {
                    secondNature.Add(flowers.Pop());
                    buckets.Pop();
                }
                else if (currWater > currFlower)
                {
                    currWater -= currFlower;
                    if (buckets.Count > 1)
                    {
                        buckets.Pop();
                        var next = buckets.Pop() + currWater;
                        buckets.Push(next);
                    }
                    else
                    {
                        buckets.Pop();
                        buckets.Push(currWater);
                    }
                    flowers.Pop();
                }
                else
                {
                    var flowerRemaining = currFlower - currWater;
                    flowers.Pop();
                    flowers.Push(flowerRemaining);
                    buckets.Pop();
                }
            }

            if (flowers.Count == 0)
            {
                var added = buckets.Peek() + savedWater;
                buckets.Pop();
                buckets.Push(added);
                Console.WriteLine(string.Join(" ",buckets));
            }
            else
            {
                Console.WriteLine(string.Join(" ", flowers));
            }

            if (secondNature.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(string.Join(" ",secondNature));
            }
        }
    }
}
