namespace EnterpriseFizzBuzz
{
    using System;

    using EnterpriseFizzBuzz.Factories;
    using EnterpriseFizzBuzz.IO;
    using EnterpriseFizzBuzz.Strategies;

    public class FizzBuzz
    {
        private readonly IIntegerDivisibilityStrategyFactory factory;

        public FizzBuzz(IIntegerDivisibilityStrategyFactory factory)
        {
            this.factory = factory;
        }

        public void Execute(int limit)
        {
            IIntegerDivisibilityStrategy threeStrategy = this.factory.GetStrategy(3);
            IIntegerDivisibilityStrategy fiveStrategy = this.factory.GetStrategy(5);

            for (int i = 0; i < limit; i++)
            {
                if (threeStrategy.Divisible(i) && fiveStrategy.Divisible(i))
                {
                    IStringWriter writer = new StringWriter(new TextWriterWrapper(Console.Out));
                    writer.Write("FizzBuzz");
                }
                else if (threeStrategy.Divisible(i))
                {
                    IStringWriter writer = new StringWriter(new TextWriterWrapper(Console.Out));
                    writer.Write("Fizz");
                }
                else if (fiveStrategy.Divisible(i))
                {
                    IStringWriter writer = new StringWriter(new TextWriterWrapper(Console.Out));
                    writer.Write("Buzz");
                }
                else
                {
                    IIntegerWriter writer = new IntegerWriter(new TextWriterWrapper(Console.Out));
                    writer.Write(i);
                }
                IStringWriter newLineWriter = new StringWriter(new TextWriterWrapper(Console.Out));
                newLineWriter.Write(Environment.NewLine);
            }
        }
    }
}