namespace TriFunction
{
    using System;
    using System.Linq;

    public class TriFunction
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < names.Count; i++)
            {
                if (IsEqualOrLarger(names[i], n))
                {
                    Console.WriteLine(names[i]);
                    break;
                }
            }
        }

        public static bool IsEqualOrLarger(string name, int n)
        {
            var sum = 0;
            foreach (var character in name)
            {
                sum += character;
            }

            if (sum >= n)
            {
                return true;
            }

            return false;
        }
    }
}
