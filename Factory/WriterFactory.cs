namespace NumberParser.Factory
{
    public static class WriterFactory
    {
        public static IWriter GetWriter(Writer writer) => writer switch
        {
            Writer.Text => new TextWriter(),
            Writer.Xml => new XmlWriter(),
            Writer.Json => new JsonWriter(),
            _ => throw new ArgumentException("Invalid argument value for writer", nameof(writer)),
        };
    }
}
