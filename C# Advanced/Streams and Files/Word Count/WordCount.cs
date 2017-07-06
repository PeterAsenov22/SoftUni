namespace Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        public static void Main()
        {
            using (var wordsReader = new StreamReader("../../words.txt"))
            {
                using (var textReader = new StreamReader("../../text.txt"))
                {
                    using (var streamWriter = new StreamWriter("../../result.txt"))
                    {
                        var wordsCount = new Dictionary<string, int>();
                        var words = wordsReader.ReadLine();

                        while (words != null)
                        {
                            var wordsParams = words.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                            foreach (var word in wordsParams)
                            {
                                wordsCount[word] = 0;
                            }

                            words = wordsReader.ReadLine();
                        }

                        var textLine = textReader.ReadLine();
                        var regex = new Regex(@"\w*");

                        while (textLine != null)
                        {
                            var matches = regex.Matches(textLine);

                            foreach (Match match in matches)
                            {
                                if (wordsCount.ContainsKey(match.Value.ToLower()))
                                {
                                    wordsCount[match.Value.ToLower()]++;
                                }
                            }

                            textLine = textReader.ReadLine();
                        }

                        foreach (var item in wordsCount.OrderByDescending(x => x.Value))
                        {
                            streamWriter.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
        }
    }
}
