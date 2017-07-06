namespace User_Logs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class UserLogs
    {
        public static void Main()
        {
            var regex = new Regex(@"^IP=(.*?)\smessage=(.*?)\suser=(.*)$");
            var userLogs = new SortedDictionary<string,Dictionary<string,int>>();
            var input = Console.ReadLine();

            while (input!="end")
            {
                var match = regex.Match(input);
                var IP = match.Groups[1].Value;
                var username = match.Groups[3].Value;

                if (!userLogs.ContainsKey(username))
                {
                    userLogs[username] = new Dictionary<string, int>();
                }

                if (!userLogs[username].ContainsKey(IP))
                {
                    userLogs[username][IP] = 0;
                }

                userLogs[username][IP]++;

                input = Console.ReadLine();
            }

            foreach (var log in userLogs)
            {
                Console.WriteLine($"{log.Key}: ");
                var IPcount = log.Value.Count();
                var count = 0;
                foreach (var ip in log.Value)
                {
                    count++;
                    if (count == IPcount)
                    {
                        Console.WriteLine($"{ip.Key} => {ip.Value}.");
                    }
                    else
                    {
                        Console.Write($"{ip.Key} => {ip.Value}, ");
                    }
                }
            }
        }
    }
}
