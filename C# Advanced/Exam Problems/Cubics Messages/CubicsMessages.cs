namespace Cubics_Messages
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class CubicsMessages
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"^(\d+)([a-zA-Z]+)([^a-zA-Z\s]*)$");

            while (input != "Over!")
            {
                var length = int.Parse(Console.ReadLine());
                
                if (regex.IsMatch(input))
                {
                    var match = regex.Match(input);
                    var message = match.Groups[2].Value;
                    if (message.Length == length)
                    {
                        var digits = match.Groups[1].Value.ToCharArray();
                        var sb = new StringBuilder();
                        foreach (var digit in digits)
                        {
                            var currIndex = int.Parse(digit.ToString());
                            if (currIndex < message.Length)
                            {
                                sb.Append(message[currIndex]);
                            }
                            else
                            {
                                sb.Append(' ');
                            }
                        }

                        if (match.Groups[3].Success)
                        {
                            var charaters = match.Groups[3].Value.ToCharArray();
                            foreach (var charact in charaters)
                            {
                                if (char.IsDigit(charact))
                                {
                                    var index = int.Parse(charact.ToString());
                                    if (index < message.Length)
                                    {
                                        sb.Append(message[index]);
                                    }
                                    else
                                    {
                                        sb.Append(' ');
                                    }
                                }
                            }
                        }

                        var vertificationCode = sb.ToString();
                        Console.WriteLine($"{message} == {vertificationCode}");
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
