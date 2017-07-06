namespace UpperCase_Words
{
    using System;
    using System.Linq;
    using System.Security;
    using System.Text;
    using System.Text.RegularExpressions;

    public class UpperCaseWords
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var regex = new Regex(@"(?<![a-zA-Z])[A-Z]+(?![a-zA-Z])");

            while (line!="END")
            {
                var offset = 0;
                var matches = regex.Matches(line);
                foreach (Match match in matches)
                {
                    var word = match.Value;             
                    var reversed = string.Join("", word.ToCharArray().Reverse().ToArray());
                    var currOffSet = 0;
                    if (word == reversed)
                    {
                        var sb = new StringBuilder();
                        for (int i = 0; i < word.Length; i++)
                        {
                            sb.Append(new string(word[i], 2));
                        }

                        reversed = sb.ToString();
                        currOffSet = word.Length;
                    }

                    var index = match.Index;
                    line = line.Remove(index+offset, word.Length);
                    line = line.Insert(index+offset, reversed);
                    offset += currOffSet;
                }
                Console.WriteLine(SecurityElement.Escape(line));
                line = Console.ReadLine();
            }        
        }
    }
}
