using System;
using System.Threading.Tasks;

using F10Y.T0009;


namespace F10Y.L0005.T001.Synchronous
{
    [WithXMarker]
    public interface IWith_Predicate<T> :
        IHas_Predicate<T>
    {
        new Func<T, bool> Predicate { get; set; }
    }
}


namespace F10Y.L0005.T001.Asynchronous
{
    [WithXMarker]
    public interface IWith_Predicate<T> :
        IHas_Predicate<T>
    {
        new Func<T, Task<bool>> Predicate { get; set; }
    }
}
