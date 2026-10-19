using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0005.L005
{
    [FunctionsMarker]
    public partial interface IDirectoryExplorer
    {
        Action<string> Get_Open()
            => Instances.OperatingSystemOperator.SwitchOn_OSPlatform<Action<string>>(
                Instances.WindowsExplorerOperator.Open_Directory_InExplorer,
                Instances.FinderOperator.Open_Directory_InFinder);

        void Open_DirectoryPath(string directoryPath)
        {
            var open = this.Get_Open();

            open(directoryPath);
        }

        void Open_DirectoryPaths(IEnumerable<string> directoryPaths)
        {
            var open = this.Get_Open();

            foreach (var directoryPath in directoryPaths)
            {
                open(directoryPath);
            }
        }

        void Open_DirectoryPaths(params string[] directoryPaths)
            => this.Open_DirectoryPaths(directoryPaths.AsEnumerable());
    }
}
