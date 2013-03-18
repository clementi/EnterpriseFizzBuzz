namespace EnterpriseFizzBuzz.IO
{
    using System.IO;

    public class TextWriterWrapper : ITextWriter
    {
        private readonly TextWriter textWriter;

        public TextWriterWrapper(TextWriter textWriter)
        {
            this.textWriter = textWriter;
        }

        public void Write(object obj)
        {
            this.textWriter.Write(obj);
        }
    }
}