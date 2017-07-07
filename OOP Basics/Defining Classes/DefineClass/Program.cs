namespace DefineClass
{
    using System;
    using System.Reflection;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var firstDateString = Console.ReadLine();
            var secondDateString = Console.ReadLine();
            var modifier = new DateModifier();
            modifier.CalculateDifference(firstDateString,secondDateString);
            Console.WriteLine(modifier.Difference);
        }
    }
}
