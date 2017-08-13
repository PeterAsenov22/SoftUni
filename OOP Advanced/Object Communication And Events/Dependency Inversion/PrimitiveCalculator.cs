namespace Dependency_Inversion
{
    using Strategies;

    public class PrimitiveCalculator
    {
        private IStrategy currentStrategy;

        public PrimitiveCalculator(IStrategy strategy)
        {
            this.currentStrategy = strategy;
        }

        public void ChangeStrategy(IStrategy strategy)
        {
            this.currentStrategy = strategy;
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            return this.currentStrategy.Calculate(firstOperand, secondOperand);
        }
    }
}
