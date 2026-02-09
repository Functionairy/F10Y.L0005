using System;

using F10Y.T0009;


namespace F10Y.L0005.L004.T000
{
    [WithXMarker]
    public interface IWith_Descriptor :
        IHas_Descriptor
    {
        new IDescriptor Descriptor { get; set; }
    }
}
