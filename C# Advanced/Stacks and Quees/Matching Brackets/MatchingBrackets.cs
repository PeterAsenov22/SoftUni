﻿namespace Matching_Brackets
{
    using System;
    using System.Collections.Generic;

    public class MatchingBrackets
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '(')
                {
                    stack.Push(i);
                }

                if(input[i] == ')')
                {
                    var startingIndex = stack.Pop();
                    var output = input.Substring(startingIndex, i - startingIndex + 1);
                    Console.WriteLine(output);
                }
            }
        }
    }
}
