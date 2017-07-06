namespace Line_Numbers
{
    using System.IO;

    public class LineNumbers
    {
        public static void Main()
        {
            using (var streamReader = new StreamReader("../../input.txt"))
            {
                using (var streamWriter = new StreamWriter("../../output.txt"))
                {
                    var line = streamReader.ReadLine();
                    var lineNumber = 1;

                    while (line!=null)
                    {
                        streamWriter.WriteLine($"{lineNumber}. {line}");

                        lineNumber++;
                        line = streamReader.ReadLine();
                    }
                }
            }
        }
    }
}
