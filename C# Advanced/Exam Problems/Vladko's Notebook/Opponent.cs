namespace Vladko_s_Notebook
{
    using System.Collections.Generic;

    public class Opponent
    {
        public string Color { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public List<string> Opponents { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }
    }
}
