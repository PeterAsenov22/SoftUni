namespace Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
        public static void Main()
        {
            var regex = new Regex(@"\b[A-Z][a-z]+\s[A-Z][a-z]+\b");
            var input = Console.ReadLine();
            while (input!="end")
            {
                var matches = regex.Matches(input);
                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }

                input = Console.ReadLine();
            }
        }
    }
}
