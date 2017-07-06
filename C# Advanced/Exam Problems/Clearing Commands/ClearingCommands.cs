namespace Clearing_Commands
{
    using System;
    using System.Collections.Generic;
    using System.Security;

    public class ClearingCommands
    {
        public static void Main()
        {
            var commands = new List<char>();
            commands.Add('>');
            commands.Add('<');
            commands.Add('^');
            commands.Add('v');
            var inputs = new List<string>();
            var input = Console.ReadLine();

            while (input!="END")
            {
                inputs.Add(input);
                input = Console.ReadLine();
            }

            var rows = inputs.Count;
            var matrix = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = inputs[i].ToCharArray();
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == '>')
                    {
                        for (int k = j+1; k < matrix[i].Length; k++)
                        {
                            if (!commands.Contains(matrix[i][k]))
                            {
                                matrix[i][k] = ' ';
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else if (matrix[i][j] == '<')
                    {
                        for (int k = j-1; k >= 0; k--)
                        {
                            if (!commands.Contains(matrix[i][k]))
                            {
                                matrix[i][k] = ' ';
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else if(matrix[i][j] == '^')
                    {
                        for (int k = i-1; k >= 0; k--)
                        {
                            if (matrix[k].Length > j)
                            {
                                if (!commands.Contains(matrix[k][j]))
                                {
                                    matrix[k][j] = ' ';
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                    else if(matrix[i][j] == 'v')
                    {
                        for (int k = i+1; k < rows; k++)
                        {
                            if (matrix[k].Length > j)
                            {
                                if (!commands.Contains(matrix[k][j]))
                                {
                                    matrix[k][j] = ' ';
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine($"<p>{SecurityElement.Escape(string.Join("",row))}</p>");
            }
        }
    }
}
