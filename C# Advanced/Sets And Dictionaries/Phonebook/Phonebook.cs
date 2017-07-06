namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phonebook
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var phonebook = new Dictionary<string,string>();
           

            while (input!="search")
            {
                var inputParams = input.Split('-');
                var name = inputParams[0];
                var number = inputParams[1];

             
                phonebook[name] = number;
                input = Console.ReadLine();
            }

            var secondInput = Console.ReadLine();
            while (secondInput!="stop")
            {
                if (phonebook.ContainsKey(secondInput))
                {
                    Console.WriteLine($"{secondInput} -> {phonebook[secondInput]}");
                }
                else
                {
                    Console.WriteLine($"Contact {secondInput} does not exist.");
                }

                secondInput = Console.ReadLine();
            }
        }
    }
}
