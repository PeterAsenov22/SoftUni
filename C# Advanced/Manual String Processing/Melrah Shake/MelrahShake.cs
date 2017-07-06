namespace Melrah_Shake
{
    using System;

    public class MelrahShake
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (true)
            {
                var firstFound = text.IndexOf(pattern);
                var lastFound = text.LastIndexOf(pattern);

                if (firstFound < 0 || lastFound == firstFound || pattern.Length==0)
                {
                    Console.WriteLine("No shake.");
                    break;
                }

                text = text.Remove(lastFound, pattern.Length);
                text = text.Remove(firstFound, pattern.Length);
                Console.WriteLine("Shaked it.");

                pattern = pattern.Remove(pattern.Length / 2, 1);
            }

            Console.WriteLine(text);
        }
    }
}