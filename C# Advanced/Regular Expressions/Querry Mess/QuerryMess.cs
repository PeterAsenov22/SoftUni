namespace Querry_Mess
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class QuerryMess
    {
        public static void Main()
        {
            var regex = new Regex(@"^(.+)=(.+)$");
            var input = Console.ReadLine();

            while (input!="END")
            {
                var dictionary = new Dictionary<string,List<string>>();
                var parts = input.Split(new[] {'?', '&'}, StringSplitOptions.RemoveEmptyEntries);

                foreach (var part in parts)
                {
                    var currElemParams = part.Split(new[] {"%20","+"}, StringSplitOptions.RemoveEmptyEntries);
                    var currentPart = string.Join(" ", currElemParams);
                    if (regex.IsMatch(currentPart))
                    {
                        var match = regex.Match(currentPart);
                        var key = match.Groups[1].Value.Trim();
                        var value = match.Groups[2].Value.Trim();

                        if (!dictionary.ContainsKey(key))
                        {
                            dictionary[key] = new List<string>();
                        }

                        dictionary[key].Add(value);
                    }
                }

                foreach (var part in dictionary)
                {
                    Console.Write($"{part.Key}=[{string.Join(", ",part.Value)}]");
                }

                Console.WriteLine();
                input = Console.ReadLine();
            }
        }
    }
}
