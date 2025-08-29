using System;

using F10Y.T0009;


namespace F10Y.L0005.T001
{
    [WithXMarker]
    public interface IWith_LastModified_DateTime :
        IHas_LastModified_DateTime
    {
        new DateTime LastModified { get; set; }
    }
}
