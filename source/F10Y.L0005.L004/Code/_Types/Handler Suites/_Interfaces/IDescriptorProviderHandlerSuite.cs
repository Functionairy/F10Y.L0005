using System;

using F10Y.T0004;

using F10Y.L0005.L004.T000;


namespace F10Y.L0005.L004
{
    /// <summary>
    /// The <see cref="Descriptor"/> type is special, in that it provides:
    /// <list type="bullet">
    /// <item>An assigned identity (<see cref="Descriptor.Identity"/>).</item>
    /// <item>An intrinsic identity (<see cref="Descriptor.Name"/>).</item>
    /// <item>A full description (<see cref="Descriptor.Description"/>).</item>
    /// </list>
    /// As such, it can be useful to provide a descriptor for a given type.
    /// </summary>
    [DataTypeMarker]
    public interface IDescriptorProviderHandlerSuite<THandled>
    {
        Func<THandled, Descriptor> Get_Descriptor { get; set; }
    }
}