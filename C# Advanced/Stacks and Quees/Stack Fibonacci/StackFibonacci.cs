namespace Stack_Fibonacci
{
    using System;
    using System.Collections.Generic;

    public class StackFibonacci
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<long>();
            stack.Push(1);
            stack.Push(1);

            if(n == 1)
            {
                Console.WriteLine(1);
            }
            else if(n==2)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 0; i <n-2; i++)
                {
                    var a = stack.Pop();
                    var b = stack.Peek();
                    stack.Push(a);
                    stack.Push(a + b);
                }

                Console.WriteLine(stack.Peek());
            }
        }
    }
}
