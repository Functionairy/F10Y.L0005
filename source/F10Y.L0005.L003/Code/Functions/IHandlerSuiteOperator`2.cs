using System;

using F10Y.T0002;


namespace F10Y.L0005.L003
{
    [FunctionsMarker]
    public partial interface IHandlerSuiteOperator<THandled, THandlerSuite> :
        TypeBased.IHandlerSuiteOperator<THandled, THandlerSuite>,
        TypeNameBased.IHandlerSuiteOperator<THandlerSuite>
    {

    }
}
