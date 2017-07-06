namespace Parse_Tags
{
    using System;

    public class ParseTags
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            while (true)
            {
                if (text.Contains("<upcase>") && text.Contains("</upcase>"))
                {
                    var openTagIndex = text.IndexOf("<upcase>");
                    if (openTagIndex < 0)
                    {
                        break;
                    }

                    var closingTagIndex = text.IndexOf("</upcase>");
                    var changedString = text.Substring(openTagIndex + 8, closingTagIndex - openTagIndex - 8);
                    text = text.Remove(openTagIndex, 8);
                    closingTagIndex = text.IndexOf("</upcase>");
                    text = text.Remove(closingTagIndex, 9);
                    text = text.Replace(changedString, changedString.ToUpper());
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(text);
        }
    }
}
