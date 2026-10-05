using System;


namespace F10Y.L0005.L002
{
    public class ServiceOperations : IServiceOperations
    {
        #region Infrastructure

        public static IServiceOperations Instance { get; } = new ServiceOperations();


        private ServiceOperations()
        {
        }

        #endregion
    }
}
