namespace EnterpriseFizzBuzz.IO
{
    public class StringWriter : ITextWriter
    {
        private readonly ITextWriter textWriter;

        public StringWriter(ITextWriter textWriter)
        {
            this.textWriter = textWriter;
        }

        public void Write(object obj)
        {
            this.textWriter.Write(obj);
        }
    }
}