using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var addCollection = new AddCollection<string>();
        var addRemoveCollection = new AddRemoveCollection<string>();
        var myList = new MyList<string>();

        var strings = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(Console.ReadLine());

        var firstOutput = new List<int>();
        var secondOutput = new List<int>();
        var thirdOutput = new List<int>();
        var fourthOutput = new List<string>();
        var fifthOutput = new List<string>();

        foreach (var item in strings)
        {
            var currFirst = addCollection.Add(item);
            firstOutput.Add(currFirst);
            var currSecond = addRemoveCollection.Add(item);
            secondOutput.Add(currSecond);
            var currThird = myList.Add(item);
            thirdOutput.Add(currThird);
        }

        for (int i = 0; i < n; i++)
        {
            var currRemoved = addRemoveCollection.Remove();
            fourthOutput.Add(currRemoved);
            currRemoved = myList.Remove();
            fifthOutput.Add(currRemoved);
        }

        Console.WriteLine(string.Join(" ",firstOutput));
        Console.WriteLine(string.Join(" ", secondOutput));
        Console.WriteLine(string.Join(" ", thirdOutput));
        Console.WriteLine(string.Join(" ", fourthOutput));
        Console.WriteLine(string.Join(" ", fifthOutput));
    }
}
