using System;

using F10Y.T0002;

using F10Y.L0005.L004.T000;


namespace F10Y.L0005.L004
{
    [FunctionsMarker]
    public partial interface IEqualityOperator
    {
        bool Are_Equal(Descriptor a, Descriptor b)
           => Instances.DescriptorOperator.Are_Equal(a, b);
    }
}
