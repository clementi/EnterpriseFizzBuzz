namespace EnterpriseFizzBuzz
{
    using System;

    using EnterpriseFizzBuzz.Factories;
    using EnterpriseFizzBuzz.IO;

    public class FizzBuzz
    {
        private readonly IWriterFactory writerFactory;

        public FizzBuzz(IWriterFactory writerFactory)
        {
            this.writerFactory = writerFactory;
        }

        public void Execute(int limit)
        {
            ITextWriter newLineWriter = new TextWriterWrapper(Console.Out);

            for (int i = 0; i < limit; i++)
            {
                ITextWriter writer = this.writerFactory.GetWriter(i);
                writer.Write(i);

                newLineWriter.Write(Environment.NewLine);
            }
        }
    }
}