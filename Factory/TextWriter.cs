namespace NumberParser.Factory
{
    public class TextWriter : IWriter
    {
        private const string FileName = "ParsedNumbers.txt";

        public string WriteContent(NumberParser parser)
        {
            File.WriteAllLines(FileName, parser.Numbers.Select(n => n.ToString()));
            return $"The output is saved in \"{FileName}\" in the current working directory.";
        }
    }
}
