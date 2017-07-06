namespace Action_Print
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ActionPrint
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries).ToList();
            Action<List<string>> printNames = list => list.ForEach(n=>Console.WriteLine(n));
            printNames(names);
        }
    }
}
