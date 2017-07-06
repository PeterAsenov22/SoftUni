namespace Champions_League
{
    using System.Collections.Generic;

    public class Team
    {
        public string Name { get; set; }

        public List<string> Opponents { get; set; }

        public int Wins { get; set; }
    }
}
