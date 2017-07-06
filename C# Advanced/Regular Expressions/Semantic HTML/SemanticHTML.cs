namespace Semantic_HTML
{
    using System;
    using System.Text.RegularExpressions;

    public class SemanticHTML
    {
        public static void Main()
        {
            var htmlOpenRegex = new Regex(@"(^\s*)<div(.*?)(?:id\s*=\s*""([a-z]+)""|class\s*=\s*\""([a-z]+)"")(.*?)>\s*$");
            var closingRegex = new Regex(@"(^\s*)<\/div>\s*<!--\s*([a-z]+)\s*-->");
            var input = Console.ReadLine();
            while (input!="END")
            {
                if (htmlOpenRegex.IsMatch(input))
                {
                    var match = htmlOpenRegex.Match(input);
                    string id;
                    if (match.Groups[3].Success)
                    {
                        id = match.Groups[3].Value;
                    }
                    else
                    {
                        id = match.Groups[4].Value;
                    }
                    var spacesInFront = match.Groups[1].Value;
                    var replace = htmlOpenRegex.Replace(input, $"<{id} $2 $5");
                    replace = replace.TrimEnd();
                    replace += ">";
                    var semantic = Regex.Replace(replace, @"\s+|\t+", " ");
                    Console.WriteLine(spacesInFront+semantic);
                }
                else if (closingRegex.IsMatch(input))
                {
                    var match = closingRegex.Match(input);
                    var semantic = closingRegex.Replace(input, "$1</$2>");
                    Console.WriteLine(semantic);
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
