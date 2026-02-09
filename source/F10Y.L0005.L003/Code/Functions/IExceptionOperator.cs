using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0005.L003
{
    [FunctionsMarker]
    public partial interface IExceptionOperator :
        L0000.IExceptionOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IExceptionOperator _L0000 => L0000.ExceptionOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Exception Get_NoHandlerSuiteFoundForDescriptorTypeException<TDescriptor>(TDescriptor descriptor)
        {
            var message = Instances.ExceptionMessageOperator.Get_NoHandlerSuiteFoundForDescriptorTypeExceptionMessage(descriptor);

            var output = this.From(message);
            return output;
        }
    }
}
