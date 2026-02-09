using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;

using F10Y.L0005.T001;


namespace F10Y.L0005.L003.TypeBased
{
    [FunctionsMarker]
    public partial interface IHandlerSuiteOperator
    {
        bool Can_Handle<THandled, THandlerSuite>(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType,
            out THandlerSuite handlerSuite_OrDefault,
            out Type implementationType)
        {
            implementationType = Instances.TypeOperator.Get_Type_ImplementationType(handled);

            var output = handlerSuites_ByHandledImplementationType.ContainsKey(implementationType);

            handlerSuite_OrDefault = output
                ? handlerSuites_ByHandledImplementationType[implementationType]
                : default
                ;

            return output;
        }

        bool Can_Handle<THandled, THandlerSuite>(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType,
            out THandlerSuite handlerSuite_OrDefault)
        {
            var output = this.Can_Handle(
                handled,
                handlerSuites_ByHandledImplementationType,
                out handlerSuite_OrDefault,
                out _);

            return output;
        }

        bool Can_Handle<THandled, THandlerSuite>(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
        {
            var output = this.Can_Handle(
                handled,
                handlerSuites_ByHandledImplementationType,
                out _);

            return output;
        }

        Dictionary<Type, THandlerSuite> Get_HandlerSuites_ByType<THandled, THandlerSuite>(IEnumerable<THandlerSuite> descriptorOperationHandlerSets)
            where THandlerSuite : IHas_Type
        {
            var output = descriptorOperationHandlerSets
                .ToDictionary(
                    x => x.Type);

            return output;
        }

        Dictionary<Type, THandlerSuite> Get_HandlerSuites_ByType<THandled, THandlerSuite>(params THandlerSuite[] descriptorOperationHandlerSets)
            where THandlerSuite : IHas_Type
        {
            var output = this.Get_HandlerSuites_ByType<THandled, THandlerSuite>(descriptorOperationHandlerSets.AsEnumerable());
            return output;
        }

        THandlerSuite Verify_CanHandle<THandled, THandlerSuite>(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByHandledImplementationType)
        {
            var can_Handle = this.Can_Handle(
                handled,
                handlerSuites_ByHandledImplementationType,
                out var handlerSuite);

            if (!can_Handle)
            {
                throw Instances.ExceptionOperator.Get_NoHandlerSuiteFoundForDescriptorTypeException(handled);
            }

            return handlerSuite;
        }
    }
}
