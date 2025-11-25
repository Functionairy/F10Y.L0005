using System;

using F10Y.T0009;


namespace F10Y.L0005.T002
{
    [WithXMarker]
    public interface IWith_Success :
        IHas_Success
    {
        new bool Success { get; set; }
    }
}
