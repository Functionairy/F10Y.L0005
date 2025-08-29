using System;

using F10Y.T0009;


namespace F10Y.L0005.T001
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Chooses <see cref="IHas_LastModified_DateTime"/> as the default.
    /// </remarks>
    [HasXMarker]
    public interface IHas_LastModified :
        IHas_LastModified_DateTime
    {
    }
}
