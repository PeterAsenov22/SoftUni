namespace Match_Count
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchCount
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();

            var regex = new Regex(word);
            var matches = regex.Matches(text);
            Console.WriteLine(matches.Count);
        }
    }
}
