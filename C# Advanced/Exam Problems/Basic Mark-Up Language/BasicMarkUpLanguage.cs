namespace Basic_Mark_Up_Language
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class BasicMarkUpLanguage
    {
        public static void Main()
        {
            var regex = new Regex(@"^\s*<\s*([a-z]+)\s+(?:value\s*=\s*\""\s*(10|[0-9])\s*\""\s+)?[a-z]+\s*=\s*\""([^""]*)\""\s*\/>\s*$");
            var input = Console.ReadLine().Trim();
            var printedCount = 1;
            while (input != "<stop/>")
            {
                if (regex.IsMatch(input))
                {
                    var match = regex.Match(input);
                    var command = match.Groups[1].Value;
                    int countToRepeat = 0;
                    if (match.Groups[2].Success)
                    {
                        countToRepeat = int.Parse(match.Groups[2].Value);
                    }
                    var content = match.Groups[3].Value;

                    if (content.Length > 0)
                    {
                        if (command == "inverse")
                        {

                            var inversed = Inverse(content);
                            Console.WriteLine($"{printedCount}. {inversed}");
                            printedCount++;

                        }
                        else if (command == "reverse")
                        {

                            var reversed = Reverse(content);
                            Console.WriteLine($"{printedCount}. {reversed}");
                            printedCount++;

                        }
                        else if (command == "repeat")
                        {
                            for (int i = 0; i < countToRepeat; i++)
                            {
                                Console.WriteLine($"{printedCount}. {content}");
                                printedCount++;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }
        }

        private static string Reverse(string content)
        {
            var array = content.ToCharArray();
            Array.Reverse(array);
            var reversed = string.Join("", array);
            return reversed;
        }

        private static string Inverse(string content)
        {
            var sb = new StringBuilder();
            var text = content.ToCharArray();
            foreach (var character in text)
            {
                if (character.ToString() == character.ToString().ToUpper())
                {
                    sb.Append(character.ToString().ToLower());
                }
                else
                {
                    sb.Append(character.ToString().ToUpper());
                }
            }

            return sb.ToString();
        }
    }
}
