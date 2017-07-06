namespace Predicate_for_Names
{
    using System;

    public class PredicateForNames
    {
        public static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            Predicate<string> predicate = s => s.Length <= length;

            for (int i = 0; i < names.Length; i++)
            {
                if (predicate(names[i]))
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }
}
