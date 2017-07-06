namespace Vowel_Count
{
    using System;
    using System.Text.RegularExpressions;

    public class VowelCount
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var regex = new Regex(@"[ayouei]");
            var matches = regex.Matches(text);
            Console.WriteLine($"Vowels: {matches.Count}");
        }
    }
}
