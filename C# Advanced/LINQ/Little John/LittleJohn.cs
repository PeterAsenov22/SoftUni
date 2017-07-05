namespace Little_John
{
    using System;
    using System.Text.RegularExpressions;

    public class LittleJohn
    {
        public static void Main()
        {
            var regex = new Regex(@"(>>>----->>)|(>>----->)|(>----->)");

            var smallArrows = 0;
            var mediumArrows = 0;
            var bigArrows = 0;

            for (int i = 0; i < 4; i++)
            {
                var input = Console.ReadLine();
                var matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    if (!string.IsNullOrEmpty(match.Groups[1].Value))
                    {
                        bigArrows++;
                    }
                    else if (!string.IsNullOrEmpty(match.Groups[2].Value))
                    {
                        mediumArrows++;
                    }
                    else
                    {
                        smallArrows++;
                    }
                }
            }

            var number = smallArrows.ToString() + mediumArrows.ToString() + bigArrows.ToString();
            var tobinary = Convert.ToString(int.Parse(number), 2);
            var reversedBinary = tobinary.ToCharArray();
            Array.Reverse(reversedBinary);
            var combined = tobinary.ToString() + string.Join("", reversedBinary);
            var backToDecimal = Convert.ToInt32(combined, 2);
            Console.WriteLine(backToDecimal);
        }
    }
}