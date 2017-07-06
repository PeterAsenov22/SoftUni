namespace Extract_Quotations
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractQuotations
    {
        public static void Main()
        {
            var regex = new Regex(@"\'(.*?)\'|\""(.*?)\""");

            var input = Console.ReadLine();
            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                if (match.Groups[1].Success)
                {
                    Console.WriteLine(match.Groups[1].Value);
                }
                else
                {
                    Console.WriteLine(match.Groups[2].Value);
                }
            }
        }
    }
}
