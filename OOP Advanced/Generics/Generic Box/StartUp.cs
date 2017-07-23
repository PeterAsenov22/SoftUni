namespace Generic_Box
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            var customList = new CustomList<string>();

            while (command != "END")
            {
                var cmdArgs = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (cmdArgs[0])
                {
                    case "Add":
                        customList.Add(cmdArgs[1]);
                        break;
                    case "Remove":
                        customList.Remove(int.Parse(cmdArgs[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(customList.Contains(cmdArgs[1]));
                        break;
                    case "Swap":
                        customList.Swap(int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(customList.CountGreaterThan(cmdArgs[1]));
                        break;
                    case "Max":
                        Console.WriteLine(customList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(customList.Min());
                        break;
                    case "Print":
                        Console.WriteLine(customList.Print());
                        break;
                    case "Sort":
                        Sorter<string>.Sort(customList);
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
