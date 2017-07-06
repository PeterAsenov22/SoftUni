namespace Add_VAT
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class VAT
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToList();
            Func<List<double>, List<double>> vat = list => list.Select(x => x * 1.2).ToList();
            var addVAT = vat(numbers);
            foreach (var number in addVAT)
            {
                Console.WriteLine($"{number:F2}");
            }
        }
    }
}
