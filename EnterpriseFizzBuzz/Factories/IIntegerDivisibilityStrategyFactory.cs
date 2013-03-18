namespace EnterpriseFizzBuzz.Factories
{
    using EnterpriseFizzBuzz.Strategies;

    public interface IIntegerDivisibilityStrategyFactory
    {
        IIntegerDivisibilityStrategy GetStrategy(int n);
    }
}