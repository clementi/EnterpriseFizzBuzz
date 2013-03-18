namespace EnterpriseFizzBuzz.IO
{
    public class IntegerWriter : IIntegerWriter
    {
        private readonly ITextWriter textWriter;

        public IntegerWriter(ITextWriter textWriter)
        {
            this.textWriter = textWriter;
        }

        public void Write(int n)
        {
            this.textWriter.Write(n);
        }
    }
}