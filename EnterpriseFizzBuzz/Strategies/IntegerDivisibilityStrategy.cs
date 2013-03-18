namespace EnterpriseFizzBuzz.Strategies
{
    internal abstract class IntegerDivisibilityStrategy : IIntegerDivisibilityStrategy
    {
        protected readonly int divisor;

        protected IntegerDivisibilityStrategy(int divisor)
        {
            this.divisor = divisor;
        }

        public bool Divisible(int n)
        {
            return n % this.divisor == 0;
        }
    }
}