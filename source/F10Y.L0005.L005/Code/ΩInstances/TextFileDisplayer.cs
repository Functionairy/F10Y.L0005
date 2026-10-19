using System;


namespace F10Y.L0005.L005
{
    public class TextFileDisplayer : ITextFileDisplayer
    {
        #region Infrastructure

        public static ITextFileDisplayer Instance { get; } = new TextFileDisplayer();


        private TextFileDisplayer()
        {
        }

        #endregion
    }
}
