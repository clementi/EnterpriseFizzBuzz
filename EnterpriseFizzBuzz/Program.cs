namespace EnterpriseFizzBuzz
{
    using EnterpriseFizzBuzz.Factories;

    public class Program
    {
        public static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz(new WriterFactory(new IntegerDivisibilityStrategyFactory()));
            fizzBuzz.Execute(100);
        }
    }
}
