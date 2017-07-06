namespace Events
{
    using System;
    using System.Collections.Generic;

    public class Location
    {
        public string Name { get; set; }

        public Dictionary<string,List<TimeSpan>> persons { get; set; }
    }
}
