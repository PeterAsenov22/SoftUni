namespace Dependency_Inversion.Factories
{
    using Strategies;

    public static class StrategyFactory
    {
        public static IStrategy GetStrategy(string @operator)
        {
            switch (@operator)
            {
                case "+":
                    return new AdditionStrategy();
                case "-":
                    return new SubtractionStrategy();
                case "*":
                    return new MultiplyStrategy();
                case "/":
                    return new DivideStrategy();
                default:
                    return new AdditionStrategy();
            }
        }
    }
}
