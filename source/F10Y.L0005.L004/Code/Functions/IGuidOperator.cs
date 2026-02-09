using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0005.L004
{
    [FunctionsMarker]
    public partial interface IGuidOperator :
        L0001.L000.IGuidOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0001.L000.IGuidOperator _L0001_L000 => L0001.L000.GuidOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        string To_String_ForDescriptor(Guid guid)
        {
            var output = this.To_String_Standard(guid);
            return output;
        }
    }
}
