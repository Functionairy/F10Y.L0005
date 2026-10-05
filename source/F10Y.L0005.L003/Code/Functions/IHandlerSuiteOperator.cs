using System;

using F10Y.T0002;


namespace F10Y.L0005.L003
{
    /// <summary>
    /// The default type-parameterless handler suite operator, uniting both by-type (<see cref="TypeBased.IHandlerSuiteOperator"/>) and by-typename (<see cref="TypeNameBased.IHandlerSuiteOperator"/>) operators.
    /// <para>
    /// The functions in this operator require a dictionary argument. For the argumentless functions, see <see cref="IHandlerSuiteOperator{THandled, THandlerSuite}"/>.
    /// </para>
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// </remarks>
    [FunctionsMarker]
    public partial interface IHandlerSuiteOperator :
        TypeBased.IHandlerSuiteOperator,
        TypeNameBased.IHandlerSuiteOperator
    {

    }
}
