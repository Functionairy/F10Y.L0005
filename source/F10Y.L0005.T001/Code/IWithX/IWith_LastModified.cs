using System;

using F10Y.T0009;


namespace F10Y.L0005.T001
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Chooses <see cref="IWith_LastModified_DateTime"/> as the default.
    /// </remarks>
    [WithXMarker]
    public interface IWith_LastModified :
        IHas_LastModified,
        IWith_LastModified_DateTime
    {
    }
}
