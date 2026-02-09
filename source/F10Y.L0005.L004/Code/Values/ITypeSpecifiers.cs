using System;

using F10Y.T0003;

using For_TypeSpecifiers = F10Y.L0001.T000;

using F10Y.L0005.L004.T000;


namespace F10Y.L0005.L004
{
    [ValuesMarker]
    public partial interface ITypeSpecifiers
    {
        #region Descriptors

        For_TypeSpecifiers.TypeSpecifier<IDescriptor> For_IDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IDescriptor>.Instance;

        For_TypeSpecifiers.TypeSpecifier<IDescriptor, Descriptor> For_Descriptor =>
            For_TypeSpecifiers.TypeSpecifier<IDescriptor, Descriptor>.Instance;

        #endregion
    }
}
