namespace Valid_Time
{
    using System;
    using System.Text.RegularExpressions;

    public class ValidTime
    {
        public static void Main()
        {
            var regex = new Regex(@"^(0[1-9]|1[012]):([0-5][0-9]):([0-5][0-9])\s(AM|PM)$");

            var input = Console.ReadLine();

            while (input!="END")
            {
                if (regex.IsMatch(input))
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                input = Console.ReadLine();
            }
        }
    }
}
