namespace Drawing_Tool
{
    using System;

    public class DrawingTool
    {
        public static void Main()
        {
            var figureToDraw = Console.ReadLine();
            if (figureToDraw == "Rectangle")
            {
                int cols = int.Parse(Console.ReadLine());
                int rows = int.Parse(Console.ReadLine());
                CorDraw.Rectangle(cols,rows);
            }
            else
            {
                int n = int.Parse(Console.ReadLine());
                CorDraw.Square(n);
            }
        }
    }
}
