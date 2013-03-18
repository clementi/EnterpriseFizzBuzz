namespace EnterpriseFizzBuzz.Tests
{
    using EnterpriseFizzBuzz.Factories;
    using EnterpriseFizzBuzz.Strategies;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IntegerDivisibilityStrategyTests
    {
        // ReSharper disable InconsistentNaming

        [TestMethod]
        public void When_executing_the_divisibility_by_five_strategy_and_the_integer_is_divisible_by_five_then_it_should_return_true()
        {
            IIntegerDivisibilityStrategyFactory factory = new IntegerDivisibilityStrategyFactory();
            
            IIntegerDivisibilityStrategy strategy = factory.GetStrategy(5);

            Assert.IsTrue(strategy.Divisible(5));
        }

        [TestMethod]
        public void When_executing_the_divisibility_by_five_strategy_and_the_integer_is_not_disivible_by_five_then_it_should_return_false()
        {
            IIntegerDivisibilityStrategyFactory factory = new IntegerDivisibilityStrategyFactory();

            IIntegerDivisibilityStrategy strategy = factory.GetStrategy(5);

            Assert.IsFalse(strategy.Divisible(1));
        }

        [TestMethod]
        public void When_executing_the_divisibility_by_three_strategy_and_the_integer_is_divisible_by_three_then_it_should_return_true()
        {
            IIntegerDivisibilityStrategyFactory factory = new IntegerDivisibilityStrategyFactory();

            IIntegerDivisibilityStrategy strategy = factory.GetStrategy(3);

            Assert.IsTrue(strategy.Divisible(3));
        }

        [TestMethod]
        public void When_executing_the_divisibility_by_three_strategy_and_the_integer_is_not_divisible_by_three_then_it_should_return_false()
        {
            IIntegerDivisibilityStrategyFactory factory = new IntegerDivisibilityStrategyFactory();

            IIntegerDivisibilityStrategy strategy = factory.GetStrategy(3);

            Assert.IsFalse(strategy.Divisible(1));
        }

        // ReSharper restore InconsistentNaming
    }
}