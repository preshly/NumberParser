using System.Text.Json;

namespace NumberParser.Factory
{
    public class JsonWriter : IWriter
    {
        private const string FileName = "ParsedNumbers.json";

        public string WriteContent(NumberParser parser)
        {
            var content = JsonSerializer.Serialize(parser);
            File.WriteAllText(FileName, content);
            return $"The output is saved in \"{FileName}\" in the current working directory.";
        }
    }
}
