namespace Character_Multiplier
{
    using System;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            var strings = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var first = strings[0];
            var second = strings[1];
            long multiplication = MultiplyCharacters(first, second);
            Console.WriteLine(multiplication);
        }

        public static long MultiplyCharacters(string first, string second)
        {
            long totalSum = 0;
            var smallerLength = Math.Min(first.Length, second.Length);
            var biggerLength = Math.Max(first.Length, second.Length);
            string small;
            string big;
            if (first.Length == smallerLength)
            {
                small = first;
                big = second;
            }
            else
            {
                small = second;
                big = first;
            }

            for (int i = 0; i < biggerLength; i++)
            {
                if (i >= smallerLength)
                {
                    totalSum += big[i];
                }
                else
                {
                    totalSum += big[i] * small[i];
                }
            }

            return totalSum;
        }
    }
}
