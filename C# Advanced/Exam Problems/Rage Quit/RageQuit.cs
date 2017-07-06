namespace Rage_Quit
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class RageQuit
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"([^\d]+)([\d]+)");
            var uniqueSymbols = new HashSet<string>();
            var matches = regex.Matches(text);
            var sb = new StringBuilder();
            foreach (Match match in matches)
            {
                var matchedText = match.Groups[1].Value;
                var timesToRepeat = int.Parse(match.Groups[2].Value);
                if (timesToRepeat > 0)
                {
                    foreach (var symbol in matchedText)
                    {
                        uniqueSymbols.Add(symbol.ToString().ToLower());
                    }
                }

                for (int i = 0; i < timesToRepeat; i++)
                {
                    sb.Append(matchedText.ToUpper());
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count}");
            Console.WriteLine(sb);
        }
    }
}
