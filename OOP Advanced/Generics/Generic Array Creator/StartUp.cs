using System;

public class StartUp
{
    public static void Main()
    {
        string[] strings = ArrayCreator.Create(5, "Pesho");
        int[] integers = ArrayCreator.Create(10, 33);

        Console.WriteLine(strings[0]);
        Console.WriteLine(integers[0]);
    }
}
