namespace EnterpriseFizzBuzz.Factories
{
    using System;

    internal class NoSuchStrategyException : Exception
    {
        public NoSuchStrategyException(int n)
            : base(string.Format("There is no such strategy for divisibility by {0}.", n))
        {
        }
    }
}