namespace Inferno_lll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Inferno
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();
            var commands = new List<string>();

            var command = Console.ReadLine();
            while (command!="Forge")
            {
                var commandParams = command.Split(';');
                if (commandParams[0] == "Exclude")
                {
                    commands.Add(commandParams[1]+";"+commandParams[2]);
                }
                else
                {
                    commands.Remove(commandParams[1] + ";" + commandParams[2]);
                }

                command = Console.ReadLine();
            }

            var numbersToExclude = new List<int>();
            for (int i = 0; i < commands.Count; i++)
            {
                var currentCommandParams = commands[i].Split(';');
                var num = int.Parse(currentCommandParams[1]);
                if (currentCommandParams[0] == "Sum Left")
                {           
                    if (numbers[0] == num)
                    {
                        numbersToExclude.Add(numbers[0]);
                    }

                    for (int j = 1; j < numbers.Count; j++)
                    {
                        if (numbers[j - 1] + numbers[j] == num)
                        {
                            numbersToExclude.Add(numbers[j]);
                        }
                    }
                }
                else if (currentCommandParams[0] == "Sum Right")
                {
                    if (numbers[numbers.Count - 1] == num)
                    {
                        numbersToExclude.Add(numbers[numbers.Count - 1]);
                    }

                    for (int j = 0; j < numbers.Count-1; j++)
                    {
                        if (numbers[j] + numbers[j + 1] == num)
                        {
                            numbersToExclude.Add(numbers[j]);
                        }
                    }
                }
                else
                {
                    if (numbers.Count == 1)
                    {
                        if (numbers[0] == num)
                        {
                            numbersToExclude.Add(numbers[0]);
                        }
                    }

                    if (numbers.Count > 1)
                    {
                        if (numbers[0] + numbers[1] == num)
                        {
                            numbersToExclude.Add(numbers[0]);
                        }

                        if (numbers[numbers.Count - 1] + numbers[numbers.Count - 2] == num)
                        {
                            numbersToExclude.Add(numbers[numbers.Count - 1]);
                        }
                    }

                    for (int j = 1; j < numbers.Count-1; j++)
                    {
                        if (numbers[j] + numbers[j + 1] + numbers[j - 1] == num)
                        {
                            numbersToExclude.Add(numbers[j]);
                        }
                    }
                }
            }

            foreach (var number in numbersToExclude)
            {
                numbers.Remove(number);
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
