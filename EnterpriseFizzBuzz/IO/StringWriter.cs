namespace EnterpriseFizzBuzz.IO
{
    public class StringWriter : IStringWriter
    {
        private readonly ITextWriter textWriter;

        public StringWriter(ITextWriter textWriter)
        {
            this.textWriter = textWriter;
        }

        public void Write(string str)
        {
            this.textWriter.Write(str);
        }
    }
}