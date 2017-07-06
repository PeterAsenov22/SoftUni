namespace Replace_A_Tag
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceTag
    {
        public static void Main()
        {
            var regex = new Regex(@"^(.*?)<a.+?(href=.*?)>(.*?)<\/a>(.*)$");
            var input = Console.ReadLine();
            while (input!="end")
            {
                if (regex.IsMatch(input))
                {
                    var match = regex.Match(input);
                    Console.WriteLine($"{match.Groups[1].Value}[URL {match.Groups[2].Value}]{match.Groups[3].Value}[/URL]{match.Groups[4].Value}");
                }
                else
                {
                    Console.WriteLine(input);
                }

                input = Console.ReadLine();
            }
        }
    }
}
