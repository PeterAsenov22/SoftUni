namespace Applied_Arithmetics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ApliedArithmetics
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();
            Func<List<int>, List<int>> add = ints => ints.Select(n => n + 1).ToList();
            Func<List<int>, List<int>> subtract = ints => ints.Select(n => n - 1).ToList();
            Func<List<int>, List<int>> multiply = ints => ints.Select(n => n * 2).ToList();
            Action<List<int>> print = ints => ints.ForEach(n=>Console.Write(n+" "));

            var command = Console.ReadLine();
            while (command!="end")
            {
                if (command == "add")
                {
                    numbers = add(numbers);
                }
                else if (command == "subtract")
                {
                    numbers = subtract(numbers);
                }
                else if (command == "multiply")
                {
                    numbers = multiply(numbers);
                }
                else
                {
                    print(numbers);
                    Console.WriteLine();
                }

                command = Console.ReadLine();
            }
        }
    }
}
