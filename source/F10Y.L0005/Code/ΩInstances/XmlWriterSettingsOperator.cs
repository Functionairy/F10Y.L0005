using System;


namespace F10Y.L0005
{
    public class XmlWriterSettingsOperator : IXmlWriterSettingsOperator
    {
        #region Infrastructure

        public static IXmlWriterSettingsOperator Instance { get; } = new XmlWriterSettingsOperator();


        private XmlWriterSettingsOperator()
        {
        }

        #endregion
    }
}
