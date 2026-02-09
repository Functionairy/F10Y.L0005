using System;


namespace F10Y.L0005.L004
{
    public class HashCodeOperator : IHashCodeOperator
    {
        #region Infrastructure

        public static IHashCodeOperator Instance { get; } = new HashCodeOperator();


        private HashCodeOperator()
        {
        }

        #endregion
    }
}
