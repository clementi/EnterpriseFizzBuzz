namespace EnterpriseFizzBuzz.IO
{
    public class IntegerWriter : ITextWriter
    {
        private readonly ITextWriter textWriter;

        public IntegerWriter(ITextWriter textWriter)
        {
            this.textWriter = textWriter;
        }

        public void Write(object obj)
        {
            this.textWriter.Write(obj);
        }
    }
}