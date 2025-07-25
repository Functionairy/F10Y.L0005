using System;
using System.Threading.Tasks;

using F10Y.T0009;


namespace F10Y.L0005.T001.Synchronous
{
    [HasXMarker]
    public interface IHas_Predicate<T>
    {
        Func<T, bool> Predicate { get; }
    }
}


namespace F10Y.L0005.T001.Asynchronous
{
    [HasXMarker]
    public interface IHas_Predicate<T>
    {
        Func<T, Task<bool>> Predicate { get; }
    }
}
