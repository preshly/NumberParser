using System.Runtime.Serialization;

namespace NumberParser.Factory
{
    public class XmlWriter : IWriter
    {
        private const string FileName = "ParsedNumbers.xml";

        public string WriteContent(NumberParser parser)
        {
            var serializer = new DataContractSerializer(typeof(NumberParser));
            using var writer = System.Xml.XmlWriter.Create(FileName);
            serializer.WriteObject(writer, parser);
            return $"The output is saved in \"{FileName}\" in the current working directory.";
        }
    }
}
