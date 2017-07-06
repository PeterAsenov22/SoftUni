namespace The_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class TheNumbers
    {
        public static void Main()
        {
            var regex = new Regex(@"\d+");
            var input = Console.ReadLine();
            var matches = regex.Matches(input);
            var encrypred = new List<string>();

            foreach (Match match in matches)
            {
                var hexValue = "0x" + int.Parse(match.Value).ToString("X4");
                encrypred.Add(hexValue);
            }

            Console.WriteLine(string.Join("-",encrypred));
        }
    }
}
