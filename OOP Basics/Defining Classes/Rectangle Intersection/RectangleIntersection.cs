namespace Rectangle_Intersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RectangleIntersection
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse)
                .ToArray();
            int n = input[0];
            int m = input[1];
            var rectangles = new List<Rectangle>();

            for (int i = 0; i < n; i++)
            {
                var inputParams = Console.ReadLine().Split();
                var rectangle = new Rectangle(inputParams[0],double.Parse(inputParams[1]), double.Parse(inputParams[2]),
                    double.Parse(inputParams[3]), double.Parse(inputParams[4]));
                rectangles.Add(rectangle);
            }

            for (int i = 0; i < m; i++)
            {
                var idParams = Console.ReadLine().Split();
                var firstRec = rectangles.FirstOrDefault(x=>x.ID == idParams[0]);
                var secondRec = rectangles.FirstOrDefault(x => x.ID == idParams[1]);
                var isIntersect = firstRec.Intersect(secondRec);
                Console.WriteLine(isIntersect.ToString().ToLower());
            }
        }
    }
}
