namespace Drawing_Tool
{
    using System;

    public class CorDraw
    {
        public static void Rectangle(int cols, int rows)
        {
            Console.WriteLine($"|{new string('-',cols)}|");
            for (int i = 0; i < rows-2; i++)
            {
                Console.WriteLine($"|{new string(' ',cols)}|");
            }
            Console.WriteLine($"|{new string('-', cols)}|");
        }

        public static void Square(int n)
        {
            Console.WriteLine($"|{new string('-', n)}|");
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine($"|{new string(' ', n)}|");
            }
            Console.WriteLine($"|{new string('-', n)}|");
        }
    }
}
