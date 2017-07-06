namespace Letters_Change_Numbers
{
    using System;

    public class LettersChangeNumbers
    {
        public static void Main()
        {
            var inputParams = Console.ReadLine().Split(new[] {' ','\t','\n','\r'}, StringSplitOptions.RemoveEmptyEntries);
            decimal totalSum = 0;

            for (int i = 0; i < inputParams.Length; i++)
            {
                var currentWord = inputParams[i];
                var firstLetter = currentWord[0];
                var lastLetter = currentWord[currentWord.Length - 1];
                currentWord = currentWord.Remove(0, 1);
                currentWord = currentWord.Remove(currentWord.Length - 1, 1);
                decimal currentSum = long.Parse(currentWord);

                if (firstLetter.ToString().ToUpper() == firstLetter.ToString())
                {
                    int letterPosition = firstLetter - 64;
                    currentSum = currentSum / letterPosition;
                }
                else
                {
                    int letterPosition = firstLetter - 96;
                    currentSum = currentSum * letterPosition;
                }

                if (lastLetter.ToString().ToUpper() == lastLetter.ToString())
                {
                    int letterPosition = lastLetter - 64;
                    currentSum = currentSum - letterPosition;
                }
                else
                {
                    int letterPosition = lastLetter - 96;
                    currentSum = currentSum + letterPosition;
                }

                totalSum += currentSum;
            }

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
