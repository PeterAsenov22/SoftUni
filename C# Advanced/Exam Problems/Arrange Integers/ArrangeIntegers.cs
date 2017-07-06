namespace Arrange_Integers
{
    using System;
    using System.Collections.Generic;

    public class ArrangeIntegers
    {
        public static void Main()
        {
            var numberStrings = new SortedDictionary<string,List<int>>();
            var inputIntegers = Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < inputIntegers.Length; i++)
            {
                var currentNumber = inputIntegers[i].ToCharArray();
                var numberToString = GetStringofDigit(currentNumber);
                if (!numberStrings.ContainsKey(numberToString))
                {
                    numberStrings[numberToString] = new List<int>();
                }
                numberStrings[numberToString].Add(i);
            }

            var listOfSortedIndexes = new List<int>();
            foreach (var number in numberStrings)
            {
                foreach (var num in number.Value)
                {
                    listOfSortedIndexes.Add(num);
                }              
            }

            for (int i = 0; i < inputIntegers.Length; i++)
            {
                if (i == inputIntegers.Length - 1)
                {
                    Console.WriteLine($"{inputIntegers[listOfSortedIndexes[i]]}");
                }
                else
                {
                    Console.Write($"{inputIntegers[listOfSortedIndexes[i]]}, ");
                }
            }
        }

        public static string GetStringofDigit(char[] currNum)
        {
            var list = new List<string>();
            foreach (var digit in currNum)
            {
                string currDigit;
                if (digit == '0')
                {
                    currDigit = "zero";
                }
                else if (digit == '1')
                {
                    currDigit = "one";
                }
                else if (digit == '2')
                {
                    currDigit = "two";
                }
                else if (digit == '3')
                {
                    currDigit = "three";
                }
                else if (digit == '4')
                {
                    currDigit = "four";
                }
                else if (digit == '5')
                {
                    currDigit = "five";
                }
                else if (digit == '6')
                {
                    currDigit = "six";
                }
                else if (digit == '7')
                {
                    currDigit = "seven";
                }
                else if (digit == '8')
                {
                    currDigit = "eight";
                }
                else
                {
                    currDigit = "nine";
                }

                list.Add(currDigit);
            }

            var numToString = string.Join("-", list);
            return numToString;
        }
    }
}
