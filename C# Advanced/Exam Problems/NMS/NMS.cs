namespace NMS
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class NMS
    {
        public static void Main()
        {
            var sb = new StringBuilder();
            var input = Console.ReadLine();
            while (input!= "---NMS SEND---")
            {
                sb.Append(input);
                input = Console.ReadLine();
            }

            var list = new List<string>();
            var text = sb.ToString();
            var lowerText = sb.ToString().ToLower();
           
            var counter = 0;
            for (int i = 0; i < sb.Length-1; i++)
            {
                if (lowerText[i].CompareTo(lowerText[i + 1]) >= 1)
                {
                    var taken = text.Substring(counter, i + 1 - counter);
                    counter = i + 1;
                    list.Add(taken);
                }
            }
            list.Add(text.Substring(counter));

            var separator = Console.ReadLine();
            Console.WriteLine(string.Join(separator, list));
        }
    }
}
