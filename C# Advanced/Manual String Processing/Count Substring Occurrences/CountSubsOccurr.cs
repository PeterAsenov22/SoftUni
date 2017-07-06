namespace Count_Substring_Occurrences
{
    using System;

    public class CountSubsOccurr
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var subWord = Console.ReadLine();
            var count = 0;

            while (true)
            {
                var found = text.IndexOf(subWord, StringComparison.CurrentCultureIgnoreCase);

                if (found < 0)
                {
                    break;
                }

                count++;
                text = text.Substring(found + 1);
            }

            Console.WriteLine(count);
        }
    }
}
