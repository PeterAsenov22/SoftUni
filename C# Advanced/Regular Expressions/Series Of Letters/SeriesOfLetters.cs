namespace Series_Of_Letters
{
    using System;
    using System.Text.RegularExpressions;

    public class SeriesOfLetters
    {
        public static void Main()
        {
            var regex = new Regex(@"([a-zA-Z])\1+");
            var text = Console.ReadLine();

            while (true)
            {
                var match = regex.Match(text);
                if (match.Success)
                {
                    text = text.Replace(match.Groups[0].Value, match.Groups[1].Value);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(text);
        }
    }
}
