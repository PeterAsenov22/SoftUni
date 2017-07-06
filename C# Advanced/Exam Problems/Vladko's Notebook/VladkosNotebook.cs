namespace Vladko_s_Notebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class VladkosNotebook
    {
        public static void Main()
        {
            var notebook = new List<Opponent>();
            var input = Console.ReadLine();
            while (input != "END")
            {
                var inputParams = input.Split('|');
                var color = inputParams[0];

                if (notebook.Any(x => x.Color == color))
                {
                    var curr = notebook.First(x => x.Color == color);
                    if (inputParams[1] == "age")
                    {
                        curr.Age = int.Parse(inputParams[2]);
                    }
                    else if(inputParams[1] == "name")
                    {
                        curr.Name = inputParams[2];
                    }
                    else if (inputParams[1] == "win")
                    {
                        curr.Wins++;
                        curr.Opponents.Add(inputParams[2]);
                    }
                    else
                    {
                        curr.Losses++;
                        curr.Opponents.Add(inputParams[2]);
                    }
                }
                else
                {
                    var opponent = new Opponent()
                    {
                        Opponents = new List<string>(),
                        Wins = 1,
                        Losses = 1,
                        Age = 0,
                        Name = string.Empty
                    };

                    opponent.Color = color;

                    if (inputParams[1] == "age")
                    {
                        opponent.Age = int.Parse(inputParams[2]);
                    }
                    else if (inputParams[1] == "name")
                    {
                        opponent.Name = inputParams[2];
                    }
                    else if (inputParams[1] == "win")
                    {
                        opponent.Wins++;
                        opponent.Opponents.Add(inputParams[2]);
                    }
                    else
                    {
                        opponent.Losses++;
                        opponent.Opponents.Add(inputParams[2]);
                    }

                    notebook.Add(opponent);
                }

                input = Console.ReadLine();
            }

            var filtered = notebook.Where(x => x.Age != 0 && x.Name != string.Empty).ToList();
            if (filtered.Count == 0)
            {
                Console.WriteLine("No data recovered.");
            }
            else
            {
                foreach (var opponent in filtered.OrderBy(x=>x.Color))
                {
                    var opponents = string.Empty;
                    if (opponent.Opponents.Count == 0)
                    {
                        opponents = "(empty)";
                    }
                    else
                    {
                        opponents = string.Join(", ", opponent.Opponents.OrderBy(x => x,StringComparer.Ordinal));
                    }

                    Console.WriteLine($"Color: {opponent.Color}");
                    Console.WriteLine($"-age: {opponent.Age}");
                    Console.WriteLine($"-name: {opponent.Name}");
                    Console.WriteLine($"-opponents: {opponents}");
                    Console.WriteLine($"-rank: {((double)opponent.Wins/opponent.Losses):F2}");
                }
            }
        }
    }
}
