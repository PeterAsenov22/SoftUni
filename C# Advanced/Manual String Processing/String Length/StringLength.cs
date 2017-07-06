namespace String_Length
{
    using System;

    public class StringLength
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            if (text.Length >= 20)
            {
                Console.WriteLine(text.Substring(0,20));
            }
            else
            {
                Console.Write(text);
                Console.WriteLine(new string('*',20-text.Length));
            }
        }
    }
}
