namespace Formatting_Numbers
{
    using System;
    using System.Linq;

    public class FormattingNumbers
    {
        public static void Main()
        {
            var inputParams = Console.ReadLine().Split(new []{' ','\t','\n','\r'},StringSplitOptions.RemoveEmptyEntries).ToArray();

            int a = int.Parse(inputParams[0]);
            double b = double.Parse(inputParams[1]);
            double c = double.Parse(inputParams[2]);

            var aToHex = a.ToString("X");
            var aToBinary = Convert.ToString(a, 2).PadLeft(10, '0');
            if (aToBinary.Length > 10)
            {
                aToBinary = aToBinary.Substring(0, 10);
            }
            Console.WriteLine("|{0,-10}|{1,-10}|{2,10:F2}|{3,-10:F3}|", aToHex, aToBinary, b, c);
        }
    }
}
