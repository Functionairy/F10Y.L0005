using System;
using System.Collections.Generic;

using F10Y.T0002;
using F10Y.T0011;

using For_HandlerSuites = F10Y.L0005.L003.TypeBased;

using F10Y.L0005.L004.T000;


namespace F10Y.L0005.L004
{
    [FunctionsMarker]
    public partial interface IDescriptorOperator :
        T000.IDescriptorOperator,
        IDescriptorProviderHandlerSuiteOperator<IDescriptor, DescriptorHandlerSuite>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        T000.IDescriptorOperator _T000 => T000.DescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles

        IDictionary<Type, DescriptorHandlerSuite> For_HandlerSuites.IHandlerSuiteOperator<IDescriptor, DescriptorHandlerSuite>.HandlerSuites_ByHandledImplementationType
            => Instances.HandlerSuiteSets.For_Descriptors_ByType;
    }
}
