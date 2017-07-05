namespace Recursive_Fibonacci
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class RecursiveFibonacci
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var fibonacciNumbers = new Dictionary<int, BigInteger>();
            var result = GetFibonacci(n,fibonacciNumbers);
            Console.WriteLine(result);
        }

        private static BigInteger GetFibonacci(int n, Dictionary<int,BigInteger> fibonacciNumbers)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                if (fibonacciNumbers.ContainsKey(n))
                {
                    return fibonacciNumbers[n];
                }
                else
                {
                    fibonacciNumbers[n] = GetFibonacci(n - 1,fibonacciNumbers) + GetFibonacci(n - 2,fibonacciNumbers);
                    return fibonacciNumbers[n];
                }
            }
        }
    }
}
