namespace Telephony
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().ToList();
            var sites = Console.ReadLine().Split().ToList();

            var smartphone = new Smartphone(numbers, sites);

            Console.WriteLine(smartphone.Call());
            Console.WriteLine(smartphone.Browse());
        }
    }
}
