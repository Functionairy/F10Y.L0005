using System;


namespace F10Y.L0005.L002
{
    public class ServiceCollectionOperator : IServiceCollectionOperator
    {
        #region Infrastructure

        public static IServiceCollectionOperator Instance { get; } = new ServiceCollectionOperator();


        private ServiceCollectionOperator()
        {
        }

        #endregion
    }
}
