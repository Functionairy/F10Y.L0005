using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0005.L003.TypeBased
{
    /// <inheritdoc cref="IHandlerSuiteOperator" path="/summary"/>
    /// <remarks>
    /// Provides the the value of the <see cref="HandlerSuites_ByHandledImplementationType"/> property to methods inherited from <see cref="IHandlerSuiteOperator"/>.
    /// </remarks>
    [FunctionsMarker]
    public partial interface IHandlerSuiteOperator<THandled, THandlerSuite> :
        IHandlerSuiteOperator
    {
        IDictionary<Type, THandlerSuite> HandlerSuites_ByHandledImplementationType { get; }


        bool Can_Handle(
            THandled value,
            out THandlerSuite handlerSuite_OrDefault,
            out Type implementationType)
            => this.Can_Handle(
                value,
                this.HandlerSuites_ByHandledImplementationType,
                out handlerSuite_OrDefault,
                out implementationType);

        bool Can_Handle(
            THandled instance,
            out THandlerSuite handlerSuite_OrDefault)
            => this.Can_Handle(
                instance,
                this.HandlerSuites_ByHandledImplementationType,
                out handlerSuite_OrDefault);

        bool Can_Handle(THandled instance)
            => this.Can_Handle(
                instance,
                this.HandlerSuites_ByHandledImplementationType);

        THandlerSuite Verify_CanHandle(THandled value)
            => this.Verify_CanHandle(
                value,
                this.HandlerSuites_ByHandledImplementationType);
    }
}
