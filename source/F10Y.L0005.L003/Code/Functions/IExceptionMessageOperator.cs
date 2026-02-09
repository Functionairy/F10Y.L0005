using System;

using F10Y.T0002;


namespace F10Y.L0005.L003
{
    [FunctionsMarker]
    public partial interface IExceptionMessageOperator
    {
        string Get_NoHandlerSuiteFoundForDescriptorTypeExceptionMessage(string implementationType_TypeName)
        {
            var message = $"No handler suite found for descriptor type '{implementationType_TypeName}'";
            return message;
        }

        string Get_NoHandlerSuiteFoundForDescriptorTypeExceptionMessage<TDescriptor>(TDescriptor descriptor)
        {
            var implementationType_TypeName = Instances.TypeOperator.Get_TypeName_OfImplementationType(descriptor);

            var output = this.Get_NoHandlerSuiteFoundForDescriptorTypeExceptionMessage(implementationType_TypeName);
            return output;
        }
    }
}
