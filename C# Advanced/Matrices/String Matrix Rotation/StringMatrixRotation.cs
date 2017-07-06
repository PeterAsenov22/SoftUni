namespace String_Matrix_Rotation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StringMatrixRotation
    {
        public static void Main()
        {
            var command = Console.ReadLine().Split(new[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var rotate = int.Parse(command[1]);
            var words = new Queue<string>();
            var maxLength = 0;

            var input = Console.ReadLine();
            while (input != "END")
            {
                if (maxLength < input.Length)
                {
                    maxLength = input.Length;
                }

                words.Enqueue(input);
                input = Console.ReadLine();
            }
         
            if (rotate > 360)
            {
                rotate = rotate - (rotate / 360) * 360;
            }

            if (rotate == 0 || rotate == 360)
            {
                var rows = words.Count();
                var cols = maxLength;
                var matrix = new char[rows][];

                for (int i = 0; i < rows; i++)
                {
                    matrix[i] = new char[cols];
                    var array = words.Dequeue().ToCharArray();
                    var count = 1;
                    for (int j = 0; j < cols; j++)
                    {
                        if (count > array.Length)
                        {
                            matrix[i][j] = ' ';
                        }
                        else
                        {
                            matrix[i][j] = array[j];
                        }

                        count++;
                    }
                }

                foreach (var row in matrix)
                {
                    Console.WriteLine(string.Join("", row));
                }
            }
            else if(rotate == 90)
            {
                var rows = maxLength;
                var cols = words.Count();
                var wordsList = words.ToArray();
                var matrix = new char[rows][];

                for (int i = 0; i < rows; i++)
                {
                    matrix[i] = new char[cols];
                }

                for (int i = 0; i < cols; i++)
                {
                    var currWord = wordsList[wordsList.Length-1-i].ToCharArray();
                    for (int j = 0; j < rows; j++)
                    {
                        if (j >= currWord.Length)
                        {
                            matrix[j][i] = ' ';
                        }
                        else
                        {
                            matrix[j][i] = currWord[j];
                        }
                    }
                }

                foreach (var row in matrix)
                {
                    Console.WriteLine(string.Join("",row));
                }
            }
            else if(rotate == 180)
            {
                var rows = words.Count();
                var cols = maxLength;
                var matrix = new char[rows][];

                for (int i = 0; i < rows; i++)
                {
                   matrix[i] = new char[cols];
                    var wordsList = words.ToArray();
                    var currWord = wordsList[wordsList.Length - 1 - i].ToCharArray().Reverse().ToArray();

                    for (int j = 0; j < cols-currWord.Length; j++)
                    {
                        matrix[i][j] = ' ';
                    }

                    var index = 0;
                    for (int j = cols-currWord.Length; j < cols; j++)
                    {
                        matrix[i][j] = currWord[index];
                        index++;
                    }
                }

                foreach (var row in matrix)
                {
                    Console.WriteLine(string.Join("", row));
                }
            }
            else
            {
                var rows = maxLength;
                var cols = words.Count();
                var wordsList = words.ToArray();
                var matrix = new char[rows][];

                for (int i = 0; i < rows; i++)
                {
                    matrix[i] = new char[cols];
                }

                for (int i = 0; i < cols; i++)
                {
                    var currWord = wordsList[i].ToCharArray().Reverse().ToArray();
                    for (int j = 0; j < rows-currWord.Length; j++)
                    {
                        matrix[j][i] = ' ';
                    }

                    var index = 0;
                    for (int j = rows-currWord.Length; j < rows; j++)
                    {
                        matrix[j][i] = currWord[index];
                        index++;
                    }
                }

                foreach (var row in matrix)
                {
                    Console.WriteLine(string.Join("", row));
                }
            }
        }
    }
}
