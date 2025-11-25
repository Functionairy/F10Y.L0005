using System;


namespace F10Y.L0005.L002
{
    public class ServicesOperator : IServicesOperator
    {
        #region Infrastructure

        public static IServicesOperator Instance { get; } = new ServicesOperator();


        private ServicesOperator()
        {
        }

        #endregion
    }
}
