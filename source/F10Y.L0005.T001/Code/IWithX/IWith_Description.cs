using System;

using F10Y.T0009;


namespace F10Y.L0005.T001
{
    [WithXMarker]
    public interface IWith_Description :
        IHas_Description
    {
        new string Description { get; set; }
    }
}
