namespace Logs_Aggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LogsAggregator
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var logs = new SortedDictionary<string,Dictionary<string,int>>();

            for (int i = 0; i < n; i++)
            {
                var inputParams = Console.ReadLine().Split();
                var IP = inputParams[0];
                var username = inputParams[1];
                var duration = int.Parse(inputParams[2]);

                if (!logs.ContainsKey(username))
                {
                    logs[username] = new Dictionary<string, int>();
                }

                if (!logs[username].ContainsKey(IP))
                {
                    logs[username][IP] = 0;
                }

                logs[username][IP] += duration;
            }

            foreach (var log in logs)
            {
                Console.Write($"{log.Key}: ");
                var ips = new List<string>();
                foreach (var ip in log.Value.OrderBy(x=>x.Key))
                {
                    ips.Add(ip.Key);
                }

                Console.WriteLine($"{log.Value.Sum(x=>x.Value)} [{string.Join(", ",ips)}]");
            }
        }
    }
}
