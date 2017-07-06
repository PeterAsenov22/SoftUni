namespace Use_Your_Chains_Buddy
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.IO;

    public class UseYourChainsBuddy
    {
        public static void Main()
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            var text = Console.ReadLine();
            var htmlRegex = new Regex(@"<p>(.*?)<\/p>");
            var decryptedText = new StringBuilder();

            var matches = htmlRegex.Matches(text);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    var currentText = match.Groups[1].Value;
                    var replacePattern = @"[^a-z0-9]";
                    currentText = Regex.Replace(currentText, replacePattern, " ");
                    currentText = Regex.Replace(currentText,@"\s+|\n+", " ");

                    var sb = new StringBuilder(currentText);
                    var smallLetters = new Regex(@"[a-z]");

                    for (int i = 0; i < currentText.Length; i++)
                    {
                        var letter = currentText[i];
                        if (smallLetters.IsMatch(letter.ToString()))
                        {
                            if (letter < 110)
                            {
                                sb[i] = (char) (letter + 13);
                            }
                            else
                            {
                                sb[i] = (char)(letter - 13);
                            }
                        }
                    }

                    currentText = sb.ToString();
                    decryptedText.Append(currentText);
                }

                Console.WriteLine(decryptedText);
            }
        }
    }
}
