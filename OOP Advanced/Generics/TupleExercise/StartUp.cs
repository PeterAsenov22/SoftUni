namespace TupleExercise
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var firstInputParams = Console.ReadLine().Trim().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var adress = firstInputParams[firstInputParams.Count-1];
            firstInputParams.RemoveAt(firstInputParams.Count-1);
            var fullName = string.Join(" ", firstInputParams);

            var tuple = new Tuple<string, string>(fullName,adress);
            Console.WriteLine(tuple.ToString());

            var secondInputParams = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var beers = int.Parse(secondInputParams[secondInputParams.Count-1]);
            secondInputParams.RemoveAt(secondInputParams.Count-1);
            var name = string.Join(" ",secondInputParams);

            var secondTuple = new Tuple<string,int>(name,beers);
            Console.WriteLine(secondTuple.ToString());

            var thirdInputParams = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var integer = int.Parse(thirdInputParams[0]);
            var @double = double.Parse(thirdInputParams[1]);
            

            var thirdTuple = new Tuple<int,double>(integer,@double);
            Console.WriteLine(thirdTuple.ToString());
        }
    }
}
