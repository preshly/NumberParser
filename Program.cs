using NumberParser.Factory;

namespace NumberParser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                throw new Exception("Expected command line input format: \"NumberParser <Comma-separated integers> <file-type>\"");
            }
            if (!Enum.TryParse(args[1], true, out Writer writer))
            {
                throw new ArgumentException($"Invalid file format: \"{args[1]}\".");
            }

            var parser = new NumberParser(args[0]);

            var factoryWriter = WriterFactory.GetWriter(writer);
            var message = factoryWriter.WriteContent(parser);
            Console.WriteLine(message);
        }
    }
}
