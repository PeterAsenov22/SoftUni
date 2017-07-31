namespace Linked_List_Traversal
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var commandParams = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (commandParams[0])
                {
                    case "Add":
                        linkedList.Add(int.Parse(commandParams[1]));
                        break;
                    case "Remove":
                        var number = int.Parse(commandParams[1]);
                        var removeIndex = linkedList.FirstIndexOf(number);
                        if (removeIndex > -1)
                        {
                            linkedList.Remove(linkedList.FirstIndexOf(number));
                        }
                        break;
                }
            }

            Console.WriteLine(linkedList.Count);
            Console.WriteLine(string.Join(" ", linkedList));
        }
    }
}
