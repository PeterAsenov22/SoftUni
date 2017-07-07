namespace Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShoppingSpree
    {
        public static void Main()
        {
            var persons = new List<Person>();
            var products = new List<Product>();
            var personsParams = Console.ReadLine().Split(new []{';'},StringSplitOptions.RemoveEmptyEntries);
            foreach (var element in personsParams)
            {
                var personParams = element.Split(new []{'='},StringSplitOptions.RemoveEmptyEntries);
                var personName = personParams[0];
                var personMoney = double.Parse(personParams[1]);

                try
                {
                    var person  = new Person(personName,personMoney);
                    persons.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            var productsParams = Console.ReadLine().Split(new []{';'},StringSplitOptions.RemoveEmptyEntries);
            foreach (var element in productsParams)
            {
                try
                {
                    var productParams = element.Split(new[] {'='}, StringSplitOptions.RemoveEmptyEntries);
                    var productName = productParams[0];
                    var productCost = double.Parse(productParams[1]);

                    var product = new Product(productName, productCost);
                    products.Add(product);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            var command = Console.ReadLine();
            while (command!="END")
            {
                var commandParams = command.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var person = persons.First(x=>x.Name==commandParams[0]);
                var product = products.First(x => x.Name == commandParams[1]);
                
                person.AddProduct(product);
                command = Console.ReadLine();
            }

            foreach (var person in persons)
            {
                if (person.Bag.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ",person.Bag)}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}
