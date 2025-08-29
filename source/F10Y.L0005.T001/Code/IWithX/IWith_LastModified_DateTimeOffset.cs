using System;

using F10Y.T0009;


namespace F10Y.L0005.T001
{
    [WithXMarker]
    public interface IWith_LastModified_DateTimeOffset :
        IHas_LastModified_DateTimeOffset
    {
        new DateTimeOffset LastModified { get; set; }
    }
}
