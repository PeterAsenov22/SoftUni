namespace Extract_Hyperlinks
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class ExtractHyperlinks
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder();
            var inputLine = Console.ReadLine();

            while (inputLine!="END")
            {
                sb.Append(inputLine);
                inputLine = Console.ReadLine();
            }

            string text = sb.ToString();

            string pattern = @"<a\s+(?:[^>]+\s+)?href\s*=\s*(?:'([^']*)'|""([^""]*)""|([^\s>]+))[^>]*>";
            var regex = new Regex(pattern);
            var matches = regex.Matches(text);

            foreach (Match hyperlink in matches)
            {
                for (int i = 1; i <= 3; i++)
                {
                    if (hyperlink.Groups[i].Length > 0)
                    {
                        Console.WriteLine(hyperlink.Groups[i].Value);
                    }
                }
            }
        }
    }
}
