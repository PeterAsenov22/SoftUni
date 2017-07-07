namespace Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string player)
        {
            if (this.players.Any(x => x.Name == player))
            {
                var playerToRemove = this.players.First(x => x.Name == player);
                this.players.Remove(playerToRemove);
            }
            else
            {
                throw new ArgumentException($"Player {player} is not in {this.name} team.");
            }
        }

        private int OverallStats()
        {
            if (this.players.Count == 0)
            {
                return 0;
            }

            double totalSkills = 0;
            foreach (var player in this.players)
            {
                totalSkills += player.Overall();
            }

            double average = totalSkills / this.players.Count;
            var overall = Math.Round(average);
            return (int) overall;
        }

        public int TeamOverall()
        {
            return OverallStats();
        }
    }
}
