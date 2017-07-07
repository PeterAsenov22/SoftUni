namespace Decimal_to_Binary
{
    using System;
    using System.Collections.Generic;

    public class DecimalToBinary
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            if(number == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                var stack = new Stack<int>();

                while (number!=0)
                {
                    stack.Push(number % 2);
                    number = number / 2;
                }

                while (stack.Count>0)
                {
                    Console.Write(stack.Pop());
                }

                Console.WriteLine();
            }
        }
    }
}
