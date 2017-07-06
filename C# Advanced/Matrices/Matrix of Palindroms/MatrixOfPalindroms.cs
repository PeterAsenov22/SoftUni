namespace Matrix_of_Palindroms
{
    using System;
    using System.Linq;

    public class MatrixOfPalindroms
    {
        public static void Main()
        {
            var matrixParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var rows = matrixParams[0];
            var cols = matrixParams[1];
            var matrix = new string[rows][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new string[cols];
                var firstAndLast = (char)(97 + i);

                for (int j = 0; j < cols; j++)
                {
                    var currMiddle = (char)(97 + i + j);
                    string currPalindrom = firstAndLast.ToString() + currMiddle.ToString() + firstAndLast.ToString();
                    matrix[i][j] = currPalindrom;
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
