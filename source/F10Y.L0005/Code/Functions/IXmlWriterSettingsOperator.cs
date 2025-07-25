using System;
using System.Xml;

using F10Y.T0002;


namespace F10Y.L0005
{
    [FunctionsMarker]
    public partial interface IXmlWriterSettingsOperator
    {
        public string DescribeTo_Text(XmlWriterSettings settings)
        {
            var indentCharacters = Instances.CharacterOperator.DisplayCharacters(
                settings.IndentChars);

            var newLineCharacters = Instances.CharacterOperator.DisplayCharacters(
                settings.NewLineChars);

            var lines = Instances.EnumerableOperator.From(
                $"{settings.Async}: Asynchronous",
                $"{settings.CheckCharacters}: Check characters",
                $"{settings.CloseOutput}: Close output",
                $"{settings.ConformanceLevel}: Conformance level",
                $"{settings.DoNotEscapeUriAttributes}: Do not escape URI attributes",
                $"{settings.Encoding.EncodingName}: Encoding",
                $"{settings.Indent}: Indent",
                $"{indentCharacters}: Indent characters",
                $"{settings.NamespaceHandling}: Namespace handling",
                $"{newLineCharacters}: New-line characters",
                $"{settings.NewLineHandling}: New-line handling",
                $"{settings.NewLineOnAttributes}: New-line on attributes",
                $"{settings.OmitXmlDeclaration}: Omit XML declaration",
                $"{settings.OutputMethod}: Output method",
                $"{settings.WriteEndDocumentOnClose}: Write end-of-document on close"
            );

            var text = Instances.TextOperator.Join_Lines(lines);
            return text;
        }
    }
}
