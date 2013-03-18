namespace EnterpriseFizzBuzz.Factories
{
    using System;

    using EnterpriseFizzBuzz.IO;

    public interface IWriterFactory
    {
        ITextWriter GetWriter(int n);
    }

    public class WriterFactory : IWriterFactory
    {
        private readonly IIntegerDivisibilityStrategyFactory divisibilityStrategyFactory;

        public WriterFactory(IIntegerDivisibilityStrategyFactory divisibilityStrategyFactory)
        {
            this.divisibilityStrategyFactory = divisibilityStrategyFactory;
        }

        public ITextWriter GetWriter(int n)
        {
            var threeStrategy = this.divisibilityStrategyFactory.GetStrategy(3);
            var fiveStrategy = this.divisibilityStrategyFactory.GetStrategy(5);

            if (threeStrategy.Divisible(n) && fiveStrategy.Divisible(n))
                return new StringWriter(new TextWriterWrapper(Console.Out));

            if (threeStrategy.Divisible(n))
                return new StringWriter(new TextWriterWrapper(Console.Out));

            if (fiveStrategy.Divisible(n))
                return new StringWriter(new TextWriterWrapper(Console.Out));

            return new IntegerWriter(new TextWriterWrapper(Console.Out));
        }
    }
}