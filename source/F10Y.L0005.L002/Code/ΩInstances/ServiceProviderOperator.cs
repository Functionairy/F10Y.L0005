using System;


namespace F10Y.L0005.L002
{
    public class ServiceProviderOperator : IServiceProviderOperator
    {
        #region Infrastructure

        public static IServiceProviderOperator Instance { get; } = new ServiceProviderOperator();


        private ServiceProviderOperator()
        {
        }

        #endregion
    }
}
