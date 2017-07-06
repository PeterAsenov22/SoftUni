namespace Reverse_String
{
    using System;

    public class ReverseString
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToCharArray();
            Array.Reverse(text);
            Console.WriteLine(text);
        }
    }
}
