namespace Sentence_Extractor
{
    using System;
    using System.Text.RegularExpressions;

    public class SentenceExtractor
    {
        public static void Main()
        {
            var keyword = Console.ReadLine();
            var text = Console.ReadLine();
            var regex = new Regex($@"(\w[^.?!]*)?(?i:\b{keyword}\b)[^.!?]*?[!.?]");
            var matches = regex.Matches(text);

            foreach (var sentence in matches)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}