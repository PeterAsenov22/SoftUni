namespace Predicate_Party
{
    using System;
    using System.Linq;

    public class PredicateParty
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
           
            Func<string, string, bool> startsWith = (s, c) => s.StartsWith(c);
            Func<string, string, bool> endsWith = (s, c) => s.EndsWith(c);
            Func<int, string, bool> lenght = (i, s) => s.Length == i;

            var command = Console.ReadLine();
            while (command!="Party!")
            {
                var commandParams = command.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if (commandParams[0] == "Remove")
                {
                    if (commandParams[1] == "StartsWith")
                    {
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (startsWith(names[i], commandParams[2]))
                            {
                                names.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                    else if(commandParams[1]=="EndsWith")
                    {
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (endsWith(names[i], commandParams[2]))
                            {
                                names.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (lenght(int.Parse(commandParams[2]),names[i]))
                            {
                                names.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }
                else
                {
                    if (commandParams[1] == "StartsWith")
                    {
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (startsWith(names[i], commandParams[2]))
                            {
                                names.Insert(i,names[i]);
                                i++;
                            }
                        }
                    }
                    else if (commandParams[1] == "EndsWith")
                    {
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (endsWith(names[i], commandParams[2]))
                            {
                                names.Insert(i,names[i]);
                                i++;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (lenght(int.Parse(commandParams[2]), names[i]))
                            {
                                names.Insert(i,names[i]);
                                i++;
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }

            if (names.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ",names)} are going to the party!");
            }
        }
    }
}
