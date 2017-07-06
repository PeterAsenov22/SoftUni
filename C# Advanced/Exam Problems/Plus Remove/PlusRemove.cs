namespace Plus_Remove
{
    using System;
    using System.Collections.Generic;

    public class PlusRemove
    {
        public static void Main()
        {
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
                matrix[i] = inputs[i].ToLower().ToCharArray();
            }

            var elementsToRemove = new List<int>[rows];
            for (int i = 0; i < rows; i++)
            {
                elementsToRemove[i] = new List<int>();
            }

            for (int i = 1; i < rows-1; i++)
            {
                var forLength =Math.Min(matrix[i - 1].Length, matrix[i + 1].Length);
                for (int j = 0; j < Math.Min(forLength-1,matrix[i].Length-2); j++)
                {
                    if (matrix[i][j] == matrix[i][j + 1] && matrix[i][j + 1] == matrix[i - 1][j + 1]
                        && matrix[i + 1][j + 1] == matrix[i][j + 1] && matrix[i][j + 1] == matrix[i][j + 2])
                    {
                        elementsToRemove[i].Add(j);
                        elementsToRemove[i].Add(j+1);
                        elementsToRemove[i].Add(j+2);
                        elementsToRemove[i-1].Add(j+1);
                        elementsToRemove[i+1].Add(j+1);
                    }
                }
            }

            var finalMatrix = new char[rows][];

            for (int i = 0; i < inputs.Count; i++)
            {
                var currLine = inputs[i].ToCharArray();
                var currLineFilterList = new List<char>();

                for (int j = 0; j < currLine.Length; j++)
                {
                    if (!elementsToRemove[i].Contains(j))
                    {
                        currLineFilterList.Add(currLine[j]);
                    }
                }

                finalMatrix[i] = currLineFilterList.ToArray();
            }

            foreach (var row in finalMatrix)
            {
                Console.WriteLine(string.Join("",row));
            }
        }
    }
}
