using System;

using F10Y.T0003;

using F10Y.L0005.L004.T000;


namespace F10Y.L0005.L004
{
    [ValuesMarker]
    public partial interface IHandlerSuites
    {
        #region Descriptors

        DescriptorHandlerSuite For_Descriptor => new DescriptorHandlerSuite
        {
            Type = Instances.TypeOperator.Get_Type<Descriptor>(),
            Get_Descriptor = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DescriptorHandlers.Get_Descriptor,
                Instances.TypeSpecifiers.For_Descriptor)
        };

        #endregion
    }
}
