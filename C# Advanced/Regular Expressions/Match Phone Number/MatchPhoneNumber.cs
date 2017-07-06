namespace Match_Phone_Number
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchPhoneNumber
    {
        public static void Main()
        {
            var regex = new Regex(@"\+359(\s|-)2\1\d{3}\1\d{4}\b");
            var input = Console.ReadLine();
            while (input != "end")
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
