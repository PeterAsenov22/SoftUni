namespace Take_Two
{
    using System;
    using System.Linq;

    public class TakeTwo
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToList();
            var intervalNumbers = numbers.FindAll(x => x >= 10 && x <= 20).Take(2).ToList();
            Console.WriteLine(string.Join(" ",intervalNumbers));
        }
    }
}
