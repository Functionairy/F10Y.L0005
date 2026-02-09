using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0005.L003.TypeNameBased
{
    [FunctionsMarker]
    public partial interface IHandlerSuiteOperator
    {
        bool Can_Handle<THandlerSuite>(
            string typeName,
            IDictionary<string, THandlerSuite> handlerSuites_ByTypeName,
            out THandlerSuite handlerSuite_OrDefault)
        {
            var output = handlerSuites_ByTypeName.ContainsKey(typeName);

            handlerSuite_OrDefault = output
                ? handlerSuites_ByTypeName[typeName]
                : default
                ;

            return output;
        }

        THandlerSuite Verify_CanHandle<THandlerSuite>(
            string descriptorTypeName,
            IDictionary<string, THandlerSuite> handlerSuites_ByTypeName)
        {
            var can_Handle = this.Can_Handle(
                descriptorTypeName,
                handlerSuites_ByTypeName,
                out var handlerSuite);

            if (!can_Handle)
            {
                throw Instances.ExceptionOperator.Get_NoHandlerSuiteFoundForDescriptorTypeException(descriptorTypeName);
            }

            return handlerSuite;
        }
    }
}
