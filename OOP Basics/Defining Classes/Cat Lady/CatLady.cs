namespace Cat_Lady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CatLady
    {
        public static void Main()
        {
            var cats = new List<Cat>();

            var input = Console.ReadLine();
            while (input!="End")
            {
                var inputParams = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                if (inputParams[0] == "Siamese")
                {
                    var cat = new Siamese(inputParams[1],int.Parse(inputParams[2]));
                    cats.Add(cat);
                }
                else if (inputParams[0] == "Cymric")
                {
                    var cat = new Cymric(inputParams[1], double.Parse(inputParams[2]));
                    cats.Add(cat);
                }
                else
                {
                    var cat = new StreetExtraordinaire(inputParams[1], int.Parse(inputParams[2]));
                    cats.Add(cat);
                }

                input = Console.ReadLine();
            }

            var catName = Console.ReadLine();
            var wantedCat = cats.First(x => x.Name == catName);
            Console.WriteLine(wantedCat.ToString());
        }
    }
}
