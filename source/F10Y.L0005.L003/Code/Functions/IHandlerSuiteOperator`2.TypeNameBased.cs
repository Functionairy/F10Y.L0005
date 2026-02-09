using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0005.L003.TypeNameBased
{
    /// <inheritdoc cref="IHandlerSuiteOperator" path="/summary"/>
    /// <remarks>
    /// Provides the the value of the <see cref="HandlerSuites_ByHandledImplementationTypeName"/> property to methods inherited from <see cref="IHandlerSuiteOperator"/>.
    /// </remarks>
    [FunctionsMarker]
    public partial interface IHandlerSuiteOperator<THandlerSuite> :
        IHandlerSuiteOperator
    {
        IDictionary<string, THandlerSuite> HandlerSuites_ByHandledImplementationTypeName { get; }


        bool Can_Handle(
            string typeName,
            out THandlerSuite handlerSuite_OrDefault)
            => this.Can_Handle(
                typeName,
                this.HandlerSuites_ByHandledImplementationTypeName,
                out handlerSuite_OrDefault);

        THandlerSuite Verify_CanHandle(string descriptorTypeName)
            => this.Verify_CanHandle(
                descriptorTypeName,
                this.HandlerSuites_ByHandledImplementationTypeName);
    }
}
