using System;

using F10Y.T0002;

using F10Y.L0005.L004.T000;


namespace F10Y.L0005.L004
{
    [FunctionsMarker]
    public partial interface IHashCodeOperator
    {
        int Get_HashCode(Descriptor descriptor)
            => Instances.DescriptorOperator.Get_HashCode(descriptor);
    }
}
