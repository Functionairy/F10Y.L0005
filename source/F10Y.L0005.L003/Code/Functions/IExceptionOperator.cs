using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0005.L003
{
    /// <summary>
    /// Exceptions for use in handler suite machinery.
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// </remarks>
    [FunctionsMarker]
    public partial interface IExceptionOperator :
        L0000.IExceptionOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IExceptionOperator _L0000 => L0000.ExceptionOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Exception Get_NoHandlerSuiteFoundForDescriptorTypeException(string implementationType_TypeName)
        {
            var message = Instances.ExceptionMessageOperator.Get_NoHandlerSuiteFoundForDescriptorTypeExceptionMessage(implementationType_TypeName);

            var output = this.From(message);
            return output;
        }

        Exception Get_NoHandlerSuiteFoundForDescriptorTypeException<TDescriptor>(TDescriptor descriptor)
        {
            var message = Instances.ExceptionMessageOperator.Get_NoHandlerSuiteFoundForDescriptorTypeExceptionMessage(descriptor);

            var output = this.From(message);
            return output;
        }
    }
}
