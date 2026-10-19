using System;


namespace F10Y.L0005.L005
{
#pragma warning disable IDE1006 // Naming Styles
    public interface Instances :
#pragma warning restore IDE1006 // Naming Styles
        Instances_Internal,
        L0000.Instances_Internal
    {
        public static L0004.L001.IFilePaths FilePaths => L0004.L001.FilePaths.Instance;
        public static L0019.INotepadPlusPlusOperator NotepadPlusPlusOperator => L0019.NotepadPlusPlusOperator.Instance;
        public static L0043.INextpadPlusPlusOperator NextpadPlusPlusOperator => L0043.NextpadPlusPlusOperator.Instance;
        public static L0032.IWindowsExplorerOperator WindowsExplorerOperator => L0032.WindowsExplorerOperator.Instance;
        public static L0041.IFinderOperator FinderOperator => L0041.FinderOperator.Instance;
    }


#pragma warning disable IDE1006 // Naming Styles
    public interface Instances_Internal
#pragma warning restore IDE1006 // Naming Styles
    {
        public static IDirectoryExplorer DirectoryExplorer => L005.DirectoryExplorer.Instance;
        public static ITextFileDisplayer TextFileDisplayer => L005.TextFileDisplayer.Instance;
    }
}