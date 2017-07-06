namespace Text_Filter
{
    using System;

    public class TextFilter
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine().Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            foreach (var banned in bannedWords)
            {
                text = text.Replace(banned, new string('*', banned.Length));
            }

            Console.WriteLine(text);
        }
    }
}
