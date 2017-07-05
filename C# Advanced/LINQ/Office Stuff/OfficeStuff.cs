namespace Office_Stuff
{
    using System;
    using System.Collections.Generic;

    public class OfficeStuff
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var companies = new SortedDictionary<string,Dictionary<string,long>>();

            for (int i = 0; i < n; i++)
            {
                var inputParams = Console.ReadLine()
                    .Split(new[] {'|', '-', ' '}, StringSplitOptions.RemoveEmptyEntries);
                var company = inputParams[0];
                var amount = long.Parse(inputParams[1]);
                var product = inputParams[2];

                if (!companies.ContainsKey(company))
                {
                    companies[company] = new Dictionary<string, long>();
                }

                if (!companies[company].ContainsKey(product))
                {
                    companies[company][product] = 0;
                }

                companies[company][product] += amount;
            }

            foreach (var company in companies)
            {
                Console.Write($"{company.Key}: ");
                var products = new List<string>();

                foreach (var product in company.Value)
                {
                    products.Add($"{product.Key}-{product.Value}");
                }

                Console.WriteLine(string.Join(", ",products));
            }
        }
    }
}
