using System;


namespace F10Y.L0005.L004
{
    public class EqualityOperator : IEqualityOperator
    {
        #region Infrastructure

        public static IEqualityOperator Instance { get; } = new EqualityOperator();


        private EqualityOperator()
        {
        }

        #endregion
    }
}
