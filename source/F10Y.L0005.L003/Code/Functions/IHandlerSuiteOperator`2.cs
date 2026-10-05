using System;

using F10Y.T0002;


namespace F10Y.L0005.L003
{
    /// <summary>
    /// The default type-parameterless handler suite operator, uniting both by-type (<see cref="TypeBased.IHandlerSuiteOperator{THandled, THandlerSuite}"/>)
    /// and by-typename (<see cref="TypeNameBased.IHandlerSuiteOperator{THandlerSuite}"/>) operators.
    /// <para>
    /// The functions in this operator do not require a dictionary argument (it is provided by the interface itself). For the argumented functions, see <see cref="IHandlerSuiteOperator"/>.
    /// </para>
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// </remarks>
    [FunctionsMarker]
    public partial interface IHandlerSuiteOperator<THandled, THandlerSuite> :
        TypeBased.IHandlerSuiteOperator<THandled, THandlerSuite>,
        TypeNameBased.IHandlerSuiteOperator<THandlerSuite>
    {

    }
}
