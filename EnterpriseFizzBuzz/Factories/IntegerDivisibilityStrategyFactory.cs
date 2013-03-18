namespace EnterpriseFizzBuzz.Factories
{
    using EnterpriseFizzBuzz.Strategies;

    public class IntegerDivisibilityStrategyFactory : IIntegerDivisibilityStrategyFactory
    {
        public IIntegerDivisibilityStrategy GetStrategy(int n)
        {
            if (n == 3)
                return new IntegerDivisibilityByThreeStrategy();
            if (n == 5)
                return new IntegerDivisibilityByFiveStrategy();

            throw new NoSuchStrategyException(n);
        }
    }
}