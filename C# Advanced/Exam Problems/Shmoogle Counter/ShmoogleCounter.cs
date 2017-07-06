namespace Shmoogle_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ShmoogleCounter
    {
        public static void Main()
        {
            var regex = new Regex(@"(?<!public\s|private\s)(?:(double)|(int))\s([a-zA-Z]+)");
            var input = Console.ReadLine();
            var ints = new List<string>();
            var doubles = new List<string>();
            while (input!= "//END_OF_CODE")
            {
                if (regex.IsMatch(input))
                {
                    var matches = regex.Matches(input);
                    foreach (Match match in matches)
                    {
                        if (match.Groups[1].Success)
                        {
                            doubles.Add(match.Groups[3].Value);
                        }
                        else
                        {
                            ints.Add(match.Groups[3].Value);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            if (doubles.Count == 0)
            {
                Console.WriteLine("Doubles: None");
            }
            else
            {
                Console.WriteLine($"Doubles: {string.Join(", ",doubles.OrderBy(x=>x))}");
            }

            if (ints.Count == 0)
            {
                Console.WriteLine("Ints: None");
            }
            else
            {
                Console.WriteLine($"Ints: {string.Join(", ",ints.OrderBy(x=>x))}");
            }
        }
    }
}
