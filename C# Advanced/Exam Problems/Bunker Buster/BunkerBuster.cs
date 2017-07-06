namespace Bunker_Buster
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class BunkerBuster
    {
        public static void Main()
        {
            var matrixParams = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var rows = matrixParams[0];
            var cols = matrixParams[1];
            var matrix = new BigInteger[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(BigInteger.Parse).ToArray();
            }

            var destroyedCells = 0;
            var bomb = Console.ReadLine();
            while (bomb != "cease fire!")
            {
                var bombParams = bomb.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var bombRow = int.Parse(bombParams[0]);
                var bombCol = int.Parse(bombParams[1]);
                var bombPower = (int)(char.Parse(bombParams[2]));
                var bombHalfPower = (int)Math.Ceiling((double) bombPower / 2);

                matrix[bombRow][bombCol] -= bombPower;
                if (bombRow - 1 >= 0)
                {
                    matrix[bombRow - 1][bombCol] -= bombHalfPower;
                    if (bombCol - 1 >= 0)
                    {
                        matrix[bombRow - 1][bombCol - 1] -= bombHalfPower;
                    }

                    if (bombCol + 1 < cols)
                    {
                        matrix[bombRow - 1][bombCol + 1] -= bombHalfPower;
                    }
                }

                if (bombCol - 1 >= 0)
                {
                    matrix[bombRow][bombCol - 1] -= bombHalfPower;
                }

                if (bombCol + 1 < cols)
                {
                    matrix[bombRow][bombCol + 1] -= bombHalfPower;
                }

                if (bombRow + 1 < rows)
                {
                    matrix[bombRow + 1][bombCol] -= bombHalfPower;
                    if (bombCol - 1 >= 0)
                    {
                        matrix[bombRow + 1][bombCol - 1] -= bombHalfPower;
                    }

                    if (bombCol + 1 < cols)
                    {
                        matrix[bombRow + 1][bombCol + 1] -= bombHalfPower;
                    }
                }

                bomb = Console.ReadLine();
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] <= 0)
                    {
                        destroyedCells++;
                    }
                }
            }

            Console.WriteLine($"Destroyed bunkers: {destroyedCells}");
            double damage = (destroyedCells*100)/(double)(rows*cols);
            Console.WriteLine($"Damage done: {damage:F1} %");
        }
    }
}
