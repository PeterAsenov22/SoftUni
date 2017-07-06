namespace Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Events
    {
        public static void Main()
        {
            var locations = new List<Location>();
            var regex = new Regex(@"^#([A-Za-z]+):\s*@([A-Za-z]+)\s*([0-1][0-9]|[2][0-3]):([0-5][0-9])$");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                if (regex.IsMatch(input))
                {
                    var match = regex.Match(input);
                    var locationName = match.Groups[2].Value;
                    var person = match.Groups[1].Value;
                    var hours = int.Parse(match.Groups[3].Value);
                    var minutes = int.Parse(match.Groups[4].Value);
                    var time = new TimeSpan(hours,minutes,0);
                    
                    if (locations.Any(x => x.Name == locationName))
                    {
                        var curr = locations.First(x => x.Name == locationName);
                        if (!curr.persons.ContainsKey(person))
                        {
                            curr.persons[person] = new List<TimeSpan>();
                        }

                        curr.persons[person].Add(time);
                    }
                    else
                    {
                        var location = new Location()
                        {
                            Name = locationName,
                            persons = new Dictionary<string, List<TimeSpan>>()
                        };

                        location.persons[person] = new List<TimeSpan>();
                        location.persons[person].Add(time);

                        locations.Add(location);
                    }
                }
            }

            var filterParams = Console.ReadLine().Split(',');
            var filteredLocations = locations.Where(x => filterParams.Contains(x.Name));

            foreach (var location in filteredLocations.OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{location.Name}:");
                var count = 1;
                foreach (var person in location.persons.OrderBy(x=>x.Key))
                {
                    Console.WriteLine($"{count}. {person.Key} -> {string.Join(", ",person.Value.OrderBy(x=>x).Select(x=>string.Format($"{x.Hours.ToString("D2")}:{x.Minutes.ToString("D2")}")))}");
                    count++;
                }
            }
        }
    }
}
