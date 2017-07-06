namespace Text_Transformer
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class TextTransformer
    {
        public static void Main(string[] args)
        {
            var sb = new StringBuilder();
            var input = Console.ReadLine();
            while (input!="burp")
            {
                sb.Append(input);
                input = Console.ReadLine();
            }

            var text = Regex.Replace(sb.ToString(), @"\s{2,}", " ");
            var regex = new Regex(@"(\$|%|&|')([^\$%&']+)\1");
            var encodedWords = new List<string>();
            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                var specialSymbol = match.Groups[1].Value;
                var weight = 0;
                if (specialSymbol == "$")
                {
                    weight = 1;
                }
                else if (specialSymbol == "%")
                {
                    weight = 2;
                }
                else if (specialSymbol == "&")
                {
                    weight = 3;
                }
                else
                {
                    weight = 4;
                }

                var word = match.Groups[2].Value;
                var newWord = new StringBuilder();
                for (int i = 0; i < word.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        var newChar = (char) ((int) word[i] + weight);
                        newWord.Append(newChar);
                    }
                    else
                    {
                        var newChar = (char)((int)word[i] - weight);
                        newWord.Append(newChar);
                    }
                }

                encodedWords.Add(newWord.ToString());
            }

            Console.WriteLine(string.Join(" ",encodedWords));
        }
    }
}
