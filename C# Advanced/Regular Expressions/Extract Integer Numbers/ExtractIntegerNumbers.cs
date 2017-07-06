namespace Extract_Integer_Numbers
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractIntegerNumbers
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"[0-9]+");
            var matches = regex.Matches(text);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
