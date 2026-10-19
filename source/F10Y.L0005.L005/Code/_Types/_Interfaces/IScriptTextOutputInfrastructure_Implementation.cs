using System;

using F10Y.T0004;

namespace F10Y.L0005.L005
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// See also: F10Y.T0014.T004.IScriptTextOutputInfrastructure_Implementation. (Uses Notepad++ and Visual Studio Code, instead of Notepad++ and Nextpad++.)
    /// </remarks>
    [UtilityTypeMarker]
    public interface IScriptTextOutputInfrastructure_Implementation :
        T0014.T001.IScriptTextOutputInfrastructure_Definition
    {
        /// <inheritdoc cref="F10Y.L0004.L001. IFilePaths.Output_TextFilePath"/>
        string T0014.T001.N001.IScriptTextOutputInfrastructure_Definition.Output_TextFilePath =>
            Instances.FilePaths.Output_TextFilePath;

        void T0014.T001.N001.IScriptTextOutputInfrastructure_Definition.Open_FilePaths(params string[] filePaths)
            => Instances.TextFileDisplayer.Open_FilePaths(filePaths);

        void T0014.T001.N001.IScriptTextOutputInfrastructure_Definition.Open_DirectoryPaths(params string[] directoryPaths)
            => Instances.DirectoryExplorer.Open_DirectoryPaths(directoryPaths);
    }
}
