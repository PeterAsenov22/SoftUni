namespace Simple_Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SimpleCalculator
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Reverse().ToArray();                       
            var stack = new Stack<string>(input);
            var result = 0;

            result += int.Parse(stack.Pop());
            
            while (stack.Count>0)
            {
                var operation = stack.Pop();
                var num = int.Parse(stack.Pop());

                if(operation == "+")
                {
                    result += num;
                }
                else
                {
                    result -= num;
                }
            }

            Console.WriteLine(result);
        }
    }
}
