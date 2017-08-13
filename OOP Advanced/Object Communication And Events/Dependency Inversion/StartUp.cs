namespace Dependency_Inversion
{
    using System;
    using Factories;
    using Strategies;

    public class StartUp
    {
        public static void Main()
        {
            IStrategy strategy = StrategyFactory.GetStrategy(String.Empty);
            PrimitiveCalculator calculator = new PrimitiveCalculator(strategy);

            string input = Console.ReadLine();
            while (input!="End")
            {
                string[] cmdParams = input.Split();

                if (cmdParams[0] == "mode")
                {
                    IStrategy newStrategy = StrategyFactory.GetStrategy(cmdParams[1]);
                    calculator.ChangeStrategy(newStrategy);
                }
                else
                {
                    int firstOperand = int.Parse(cmdParams[0]);
                    int secondOperand = int.Parse(cmdParams[1]);
                    int result = calculator.PerformCalculation(firstOperand, secondOperand);
                    Console.WriteLine(result);
                }

                input = Console.ReadLine();
            }
        }
    }
}
