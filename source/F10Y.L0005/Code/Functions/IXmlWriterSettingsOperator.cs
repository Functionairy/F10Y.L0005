using System;
using System.Collections.Generic;
using System.Xml;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0005
{
    [FunctionsMarker]
    public partial interface IXmlWriterSettingsOperator :
        L0000.IXmlWriterSettingsOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IXmlWriterSettingsOperator _L0000 => L0000.XmlWriterSettingsOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        IEnumerable<string> Describe_ToLines(XmlWriterSettings settings)
        {
            var indentCharacters = Instances.CharacterOperator.DisplayCharacters(
                settings.IndentChars);

            var newLineCharacters = Instances.CharacterOperator.DisplayCharacters(
                settings.NewLineChars);

            var output = Instances.EnumerableOperator.From(
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

            return output;
        }

        string Describe_ToText(XmlWriterSettings settings)
        {
            var lines = this.Describe_ToLines(settings);

            var text = Instances.TextOperator.Join_Lines(lines);
            return text;
        }
    }
}
