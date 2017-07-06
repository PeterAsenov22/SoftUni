namespace Olympics_Are_Coming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class OlympicsAreComing
    {
        public static void Main()
        {
            var winners = new Dictionary<string,Dictionary<string,int>>();
            var input = Console.ReadLine();
            while (input!="report")
            {
                input = Regex.Replace(input, @"\s{2,}", " ");
                var inputParams = input.Split('|').Select(x => x.Trim()).ToArray();
                var person = inputParams[0];
                var country = inputParams[1];

                if (!winners.ContainsKey(country))
                {
                    winners[country] = new Dictionary<string, int>();
                }

                if (!winners[country].ContainsKey(person))
                {
                    winners[country][person] = 0;
                }

                winners[country][person]++;

                input = Console.ReadLine();
            }

            foreach (var country in winners.OrderByDescending(x=>x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} ({country.Value.Count} participants): {country.Value.Values.Sum()} wins");
            }
        }
    }
}
