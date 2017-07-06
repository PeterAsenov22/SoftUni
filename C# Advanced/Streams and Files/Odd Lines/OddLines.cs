namespace Odd_Lines
{
    using System;
    using System.IO;

    public class OddLines
    {
        public static void Main()
        {
            using (var streamReader = new StreamReader("../../text.txt"))
            {
                string line = streamReader.ReadLine();
                var lineIndex = 0;

                while (line != null)
                {
                    if (lineIndex % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }

                    lineIndex++;
                    line = streamReader.ReadLine();
                }
            }
        }
    }
}
