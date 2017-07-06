namespace Extract_Email
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmail
    {
        public static void Main()
        {
            var regex = new Regex(@"\s{1}[A-Za-z0-9][\w\d\.-]*[A-Za-z0-9]\@[A-Za-z][A-Za-z-]*[A-Za-z]\.[A-Za-z][A-Za-z-]*[A-Za-z](\.[a-zA-Z][A-Za-z-]*[A-Za-z]+)*");
            var input = Console.ReadLine();
            var matches = regex.Matches(input);

            foreach (var match in matches)
            {
                Console.WriteLine(match.ToString().Remove(0,1));
            }
        }
    }
}
