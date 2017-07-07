namespace Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FootballTeamGenerator
    {
        public static void Main()
        {
            var teams = new List<Team>();
            var input = Console.ReadLine();
            while (input!="END")
            {
                var inputParams = input.Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                if (inputParams[0] == "Team")
                {
                    var team = new Team(inputParams[1]);
                    teams.Add(team);
                }
                else if(inputParams[0]=="Add")
                {
                    var wantedTeam = inputParams[1];
                    if (teams.Any(x => x.Name == wantedTeam))
                    {
                        var team = teams.First(x => x.Name == wantedTeam);
                        try
                        {
                            var player = new Player(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]),
                                int.Parse(inputParams[5]), int.Parse(inputParams[6]), int.Parse(inputParams[7]));
                            team.AddPlayer(player);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }                     
                    }
                    else
                    {
                        Console.WriteLine($"Team {wantedTeam} does not exist.");
                    }
                }
                else if (inputParams[0] == "Remove")
                {
                    var wantedTeam = inputParams[1];
                    if (teams.Any(x => x.Name == wantedTeam))
                    {
                        var team = teams.First(x => x.Name == wantedTeam);
                        try
                        {
                            team.RemovePlayer(inputParams[2]);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Team {wantedTeam} does not exist.");
                    }
                }
                else if (inputParams[0] == "Rating")
                {
                    var wantedTeam = inputParams[1];
                    if (teams.Any(x => x.Name == wantedTeam))
                    {
                        var team = teams.First(x => x.Name == wantedTeam);
                        Console.WriteLine($"{team.Name} - {team.TeamOverall()}");
                    }
                    else
                    {
                        Console.WriteLine($"Team {wantedTeam} does not exist.");
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
