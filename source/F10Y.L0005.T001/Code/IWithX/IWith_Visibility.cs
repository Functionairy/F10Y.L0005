using System;

using F10Y.L0001.T000;
using F10Y.T0009;


namespace F10Y.L0005.T001
{
    [WithXMarker]
    public interface IWith_Visibility :
        IHas_Visibility
    {
        new Visibility Visibility { get; set; }
    }
}
