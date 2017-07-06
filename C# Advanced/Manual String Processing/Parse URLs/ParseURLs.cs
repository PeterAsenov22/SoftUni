namespace Parse_URLs
{
    using System;
    using System.Linq;

    public class ParseURLs
    {
        public static void Main()
        {
            var URLParams = Console.ReadLine().Split(new []{"://"},StringSplitOptions.RemoveEmptyEntries);
            if (URLParams.Length != 2)
            {
                Console.WriteLine("Invalid URL");
            }
            else
            {
                if (!URLParams[1].Contains('/'))
                {
                    Console.WriteLine("Invalid URL");
                }
                else
                {

                    var protocol = URLParams[0];
                    var server = URLParams[1].Substring(0, URLParams[1].IndexOf('/'));
                    var resources = URLParams[1].Substring(URLParams[1].IndexOf('/') + 1);

                    Console.WriteLine($"Protocol = {protocol}");
                    Console.WriteLine($"Server = {server}");
                    Console.WriteLine($"Resources = {resources}");
                }
            }
        }
    }
}
