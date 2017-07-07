namespace Balanced_Parantheses
{
    using System;
    using System.Collections.Generic;

    public class BalancedParantheses
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                var notBalanced = false;
                var stack = new Stack<char>();
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '(' || input[i] == '{' || input[i] == '[')
                    {
                        stack.Push(input[i]);
                    }
                    else
                    {
                        if (stack.Count > 0)
                        {
                            var curr = stack.Pop();
                            if (curr == '(' && input[i] != ')')
                            {
                                notBalanced = true;
                                break;
                            }
                            if (curr == '{' && input[i] != '}')
                            {
                                notBalanced = true;
                                break;
                            }
                            if (curr == '[' && input[i] != ']')
                            {
                                notBalanced = true;
                                break;
                            }

                        }
                        else
                        {
                            notBalanced = true;
                            break;
                        }
                    }
                }

                if(notBalanced)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}
