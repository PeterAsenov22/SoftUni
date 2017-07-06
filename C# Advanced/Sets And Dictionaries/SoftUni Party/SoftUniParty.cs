namespace SoftUni_Party
{
    using System;
    using System.Collections.Generic;

    public class SoftUniParty
    {
        public static void Main()
        {
            var VIP = new SortedSet<string>();
            var regular = new SortedSet<string>();

            var input = Console.ReadLine();

            while (input!="PARTY")
            {
                if(char.IsDigit(input[0]))
                {
                    VIP.Add(input);
                }
                else
                {
                    regular.Add(input);
                }

                input = Console.ReadLine();
            }

            var newInput = Console.ReadLine();

            while (newInput!="END")
            {
                if(char.IsDigit(newInput[0]))
                {
                    VIP.Remove(newInput);
                }
                else
                {
                    regular.Remove(newInput);
                }

                newInput = Console.ReadLine();
            }

            Console.WriteLine(VIP.Count + regular.Count);
            foreach (var guest in VIP)
            {
                Console.WriteLine(guest);
            }
            foreach (var guest in regular)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
