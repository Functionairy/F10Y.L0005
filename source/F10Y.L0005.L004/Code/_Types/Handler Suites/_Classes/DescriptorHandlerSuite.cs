using System;

using F10Y.L0005.T001;
using F10Y.T0004;

using F10Y.L0005.L004.T000;


namespace F10Y.L0005.L004
{
    [DataTypeMarker]
    public class DescriptorHandlerSuite :
        IDescriptorProviderHandlerSuite<IDescriptor>,
        IWith_Type
    {
        public Type Type { get; set; }

        public Func<IDescriptor, Descriptor> Get_Descriptor { get; set; }
    }
}
