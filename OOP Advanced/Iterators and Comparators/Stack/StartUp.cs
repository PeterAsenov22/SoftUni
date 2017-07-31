namespace Stack
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>();

            while (input!="END")
            {
                var inputParams = input.Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToList();
                var command = inputParams[0];
                inputParams.RemoveAt(0);

                switch (command)
                {
                    case "Push":
                        stack.Push(inputParams.Select(int.Parse).ToArray());
                        break;
                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }             
                        break;
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var element in stack)
                {
                    Console.WriteLine(element);
                }
            }         
        }
    }
}
