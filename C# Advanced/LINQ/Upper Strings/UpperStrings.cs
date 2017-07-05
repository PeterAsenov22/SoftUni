namespace Upper_Strings
{
    using System;
    using System.Linq;

    public class UpperStrings
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(' ').ToList(); ;
            names.ForEach(x=>Console.Write(x.ToUpper()+ " "));
            Console.WriteLine();
        }
    }
}
