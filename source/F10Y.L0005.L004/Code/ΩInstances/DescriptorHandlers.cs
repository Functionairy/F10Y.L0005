using System;


namespace F10Y.L0005.L004
{
    public class DescriptorHandlers : IDescriptorHandlers
    {
        #region Infrastructure

        public static IDescriptorHandlers Instance { get; } = new DescriptorHandlers();


        private DescriptorHandlers()
        {
        }

        #endregion
    }
}
