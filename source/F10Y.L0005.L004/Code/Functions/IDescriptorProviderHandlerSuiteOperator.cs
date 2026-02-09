using System;

using F10Y.L0005.L003.TypeBased;
using F10Y.T0002;

using F10Y.L0005.L004.T000;


namespace F10Y.L0005.L004
{
    [FunctionsMarker]
    public partial interface IDescriptorProviderHandlerSuiteOperator<THandled, THandlerSuite> :
        IHandlerSuiteOperator<THandled, THandlerSuite>,
        N001.IDescriptorProviderHandlerSuiteOperator<THandled, THandlerSuite>
        where THandlerSuite : IDescriptorProviderHandlerSuite<THandled>
    {
        Descriptor Get_Descriptor(
            THandled handled)
            => this.Get_Descriptor(
                handled,
                this.HandlerSuites_ByHandledImplementationType);

        string Get_Description(THandled handled)
            => this.Get_Description(
                handled,
                this.HandlerSuites_ByHandledImplementationType);

        Guid Get_Identity(THandled handled)
            => this.Get_Identity(
                handled,
                this.HandlerSuites_ByHandledImplementationType);

        string Get_Name(THandled handled)
            => this.Get_Name(
                handled,
                this.HandlerSuites_ByHandledImplementationType);
    }
}
