
namespace Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.Strategy
{
    public class StrategyContext
    {
        private IStrategy _strategy;

        public StrategyContext(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public double Execute(double a, double b)
        {
            return _strategy.Execute(a, b);
        }
    }
}
