namespace Fix_Emails
{
    using System;
    using System.Collections.Generic;

    public class FixEmails
    {
        public static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var dictionary = new Dictionary<string,string>();

            while (name!="stop")
            {
                var email = Console.ReadLine();

                if (!email.ToLower().EndsWith("us") && !email.ToLower().EndsWith("uk"))
                {
                    dictionary[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
