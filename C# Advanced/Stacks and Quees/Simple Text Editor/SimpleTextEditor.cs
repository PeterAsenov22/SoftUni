namespace Simple_Text_Editor
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System;

    public class SimpleTextEditor
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var text = new StringBuilder();
            var stack = new Stack<string>();
            stack.Push(text.ToString());

            for (int i = 0; i < n; i++)
            {
                var inputParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (inputParams[0] == "1")
                {
                    text.Append(inputParams[1]);
                    stack.Push(text.ToString());
                }
                else if (inputParams[0] == "2")
                {
                    var count = int.Parse(inputParams[1]);
                    text.Remove(text.Length - count, count);
                    stack.Push(text.ToString());
                }
                else if (inputParams[0] == "3")
                {
                    var index = int.Parse(inputParams[1]);
                    Console.WriteLine(text[index-1]);
                }
                else
                {
                    stack.Pop();
                    var newText = new StringBuilder(stack.Peek());
                    text = newText;
                }               
            }
        }
    }
}
