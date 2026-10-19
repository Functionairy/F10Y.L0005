using System;


namespace F10Y.L0005.L005
{
    public class DirectoryExplorer : IDirectoryExplorer
    {
        #region Infrastructure

        public static IDirectoryExplorer Instance { get; } = new DirectoryExplorer();


        private DirectoryExplorer()
        {
        }

        #endregion
    }
}
