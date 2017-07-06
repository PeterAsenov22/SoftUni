namespace PhoneNumbers
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var text = new StringBuilder();
            while (input!="END")
            {
                text.Append(input);
                input = Console.ReadLine();
            }

            var regex = new Regex(@"([A-Z][a-zA-Z]{0,})[^a-zA-Z+0-9]*(\+?[0-9][0-9().\s\/-]*[0-9])");
            var matches = regex.Matches(text.ToString());
            if (matches.Count == 0)
            {
                Console.WriteLine("<p>No matches!</p>");
            }
            else
            {
                Console.Write("<ol>");
                foreach (Match match in matches)
                {
                    var name = match.Groups[1].Value;
                    var number = match.Groups[2].Value;
                    number = Regex.Replace(number, "[^0-9+]", "");
                    Console.Write($"<li><b>{name}:</b> {number}</li>");
                }
                Console.WriteLine("</ol>");
            }
        }
    }
}
