using System;


namespace F10Y.L0005.L004
{
    public class DescriptorOperator : IDescriptorOperator
    {
        #region Infrastructure

        public static IDescriptorOperator Instance { get; } = new DescriptorOperator();


        private DescriptorOperator()
        {
        }

        #endregion
    }
}
