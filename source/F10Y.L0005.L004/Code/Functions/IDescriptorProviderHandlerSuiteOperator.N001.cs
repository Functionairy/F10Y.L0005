using System;
using System.Collections.Generic;

using F10Y.L0005.L003.TypeBased;
using F10Y.T0002;

using F10Y.L0005.L004.T000;


namespace F10Y.L0005.L004.N001
{
    [FunctionsMarker]
    public partial interface IDescriptorProviderHandlerSuiteOperator<THandled, THandlerSuite> :
        IHandlerSuiteOperator
        where THandlerSuite : IDescriptorProviderHandlerSuite<THandled>
    {
        Descriptor Get_Descriptor(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
        {
            var handler = this.Verify_CanHandle(
                handled,
                handlerSuites_ByHandledImplementationType);

            var output = handler.Get_Descriptor(handled);
            return output;
        }

        string Get_Description(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
        {
            var descriptor = this.Get_Descriptor(
                handled,
                handlerSuites_ByHandledImplementationType);

            var output = descriptor.Description;
            return output;
        }

        Guid Get_Identity(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
        {
            var descriptor = this.Get_Descriptor(
                handled,
                handlerSuites_ByHandledImplementationType);

            var output = descriptor.Identity;
            return output;
        }

        string Get_Name(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
        {
            var descriptor = this.Get_Descriptor(
                handled,
                handlerSuites_ByHandledImplementationType);

            var output = descriptor.Name;
            return output;
        }
    }
}
