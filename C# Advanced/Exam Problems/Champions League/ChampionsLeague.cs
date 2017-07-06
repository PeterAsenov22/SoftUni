namespace Champions_League
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ChampionsLeague
    {
        public static void Main()
        {
            var teams = new List<Team>();
            var input = Console.ReadLine();
            while (input!="stop")
            {
                var inputParams = input.Split('|').Select(x => x.Trim()).ToArray();
                var homeTeamName = inputParams[0];
                var awayTeamName = inputParams[1];
                var firstLegScore = inputParams[2].Split(':');
                var secondLegScore = inputParams[3].Split(':');
                var firstTeamHomeGoals = int.Parse(firstLegScore[0]);
                var firstTeamAwayGoals = int.Parse(secondLegScore[1]);
                var secondTeamHomeGoals = int.Parse(secondLegScore[0]);
                var secondTeamAwayGoals = int.Parse(firstLegScore[1]);
                var firstTeamTotalGoals = firstTeamHomeGoals + firstTeamAwayGoals;
                var secondTeamTotalGoals = secondTeamHomeGoals + secondTeamAwayGoals;

                Team homeTeam;
                Team awayTeam;
                if (teams.Any(x => x.Name == homeTeamName))
                {
                    homeTeam = teams.First(x => x.Name == homeTeamName);
                }
                else
                {
                    var team = new Team()
                    {
                        Name = homeTeamName,
                        Opponents = new List<string>(),
                        Wins = 0
                    };

                    teams.Add(team);
                    homeTeam = team;
                }

                if (teams.Any(x => x.Name == awayTeamName))
                {
                    awayTeam = teams.First(x => x.Name == awayTeamName);
                }
                else
                {
                    var team = new Team()
                    {
                        Name = awayTeamName,
                        Opponents = new List<string>(),
                        Wins = 0
                    };

                    teams.Add(team);
                    awayTeam = team;
                }

                homeTeam.Opponents.Add(awayTeamName);
                awayTeam.Opponents.Add(homeTeamName);

                if (firstTeamTotalGoals > secondTeamTotalGoals)
                {
                    homeTeam.Wins++;                    
                }
                else if(firstTeamTotalGoals<secondTeamTotalGoals)
                {
                    awayTeam.Wins++;                   
                }
                else
                {
                    if (firstTeamAwayGoals > secondTeamAwayGoals)
                    {
                        homeTeam.Wins++;
                    }
                    else
                    {
                        awayTeam.Wins++;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var team in teams.OrderByDescending(x=>x.Wins).ThenBy(x=>x.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- Wins: {team.Wins}");
                Console.WriteLine($"- Opponents: {string.Join(", ",team.Opponents.OrderBy(x=>x))}");
            }
        }
    }
}
