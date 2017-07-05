namespace Maximum_Element
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaximumElement
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            var maxNum = int.MinValue;
            var maxStack = new Stack<int>();
            maxStack.Push(maxNum);

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
               

                if(input[0] == 1)
                {
                    stack.Push(input[1]);
                    if(input[1]>maxNum)
                    {
                        maxNum = input[1];
                        maxStack.Push(maxNum);
                    }
                }
                else if(input[0] == 2)
                {
                    if(stack.Count>0)
                    {
                        var pop = stack.Pop();
                        if(pop==maxNum)
                        {
                            maxStack.Pop();
                            maxNum = maxStack.Peek();
                        }
                    }
                }
                else
                {
                    if(stack.Count>0)
                    {
                        Console.WriteLine(maxNum);
                    }
                }
            }
        }
    }
}
