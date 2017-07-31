namespace ListyIterator
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var iterator = new ListIterator<string>();

            while (input!="END")
            {
                var inputParams = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

                switch (inputParams[0])
                {
                    case "Create":
                        inputParams.RemoveAt(0);
                        iterator = new ListIterator<string>(inputParams.ToArray());
                        break;
                    case "Print":
                        try
                        {
                            iterator.Print();
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "HasNext":
                        Console.WriteLine(iterator.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(iterator.Move());
                        break;
                    case "PrintAll":
                        iterator.PrintAll();
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
