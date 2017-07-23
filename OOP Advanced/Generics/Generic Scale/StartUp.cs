using System;

public class StartUp
{
    public static void Main()
    {
        var stringScale = new Scale<string>("a","c");
        Console.WriteLine(stringScale.GetHeavier());

        var intScale = new Scale<int>(2,10);
        Console.WriteLine(intScale.GetHeavier());
    }
}
