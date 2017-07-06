namespace Srubsko_Unleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class SrubskoUnleashed
    {
        public static void Main()
        {
            var regex = new Regex(@"^(.*)\s\@(.*?)\s(\d+)\s(\d+)$");
            var concerts = new Dictionary<string,Dictionary<string,long>>();

            var input = Console.ReadLine();

            while (input!="End")
            {
                if (regex.IsMatch(input))
                {
                    var match = regex.Match(input);
                    var singer = match.Groups[1].Value;
                    var venue = match.Groups[2].Value;
                    var price = long.Parse(match.Groups[3].Value);
                    var count = long.Parse(match.Groups[4].Value);

                    if (!concerts.ContainsKey(venue))
                    {
                        concerts[venue] = new Dictionary<string, long>();
                    }

                    if (!concerts[venue].ContainsKey(singer))
                    {
                        concerts[venue][singer] = 0;
                    }

                    concerts[venue][singer] += price * count;
                }

                input = Console.ReadLine();
            }

            foreach (var city in concerts)
            {
                Console.WriteLine($"{city.Key}");

                foreach (var singer in city.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
