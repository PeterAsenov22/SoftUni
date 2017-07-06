namespace Party_Reservation_Filter_Module
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PartyReservation
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var commands = new List<string>();
            Func<string, string, bool> startsWith = (s, c) => s.StartsWith(c);
            Func<string, string, bool> endsWith = (s, c) => s.EndsWith(c);
            Func<int, string, bool> lenght = (r, s) => s.Length == r;

            var command = Console.ReadLine();
            while (command != "Print")
            {
                var commandParams = command.Split(';');
                if (commandParams[0] == "Add filter")
                {
                    commands.Add(commandParams[1] + ";" + commandParams[2]);
                }
                else
                {
                    commands.Remove(commandParams[1] + ";" + commandParams[2]);
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < commands.Count; i++)
            {
                var currentCommandParams = commands[i].Split(';');

                if (currentCommandParams[0] == "Starts with")
                {
                    for (int n = 0; n < names.Count; n++)
                    {
                        if (startsWith(names[n], currentCommandParams[1]))
                        {
                            names.RemoveAt(n);
                            i--;
                        }
                    }
                }
                else if (currentCommandParams[0] == "Ends with")
                {
                    for (int m = 0; m < names.Count; m++)
                    {
                        if (endsWith(names[m], currentCommandParams[1]))
                        {
                            names.RemoveAt(m);
                            i--;
                        }
                    }
                }
                else if (currentCommandParams[0] == "Length")
                {
                    for (int l = 0; l < names.Count; l++)
                    {
                        if (lenght(int.Parse(currentCommandParams[1]), names[l]))
                        {
                            names.RemoveAt(l);
                            i--;
                        }
                    }
                }
                else
                {
                    names.RemoveAll(x => x.Contains(currentCommandParams[1]));
                }
            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
