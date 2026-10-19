using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0005.L005
{
    [FunctionsMarker]
    public partial interface ITextFileDisplayer
    {
        Action<string> Get_Open()
            => Instances.OperatingSystemOperator.SwitchOn_OSPlatform<Action<string>>(
                Instances.NotepadPlusPlusOperator.Open,
                Instances.NextpadPlusPlusOperator.Open);

        void Open_FilePath(string filePath)
        {
            var open = this.Get_Open();

            open(filePath);
        }

        void Open_FilePaths(IEnumerable<string> filePaths)
        {
            var open = this.Get_Open();

            foreach (var directoryPath in filePaths)
            {
                open(directoryPath);
            }
        }

        void Open_FilePaths(params string[] filePaths)
            => this.Open_FilePaths(filePaths.AsEnumerable());
    }
}
