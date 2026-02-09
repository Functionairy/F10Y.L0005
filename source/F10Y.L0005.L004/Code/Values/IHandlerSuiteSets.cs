using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0003;


namespace F10Y.L0005.L004
{
    [ValuesMarker]
    public partial interface IHandlerSuiteSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IHandlerSuites _HandlerSuites => HandlerSuites.Instance;

#pragma warning restore IDE1006 // Naming Styles


        #region Descriptors

        DescriptorHandlerSuite[] For_Descriptors => new[]
        {
            _HandlerSuites.For_Descriptor,
        };

        private static readonly Lazy<Dictionary<Type, DescriptorHandlerSuite>> For_Descriptors_ByType_Lazy = new Lazy<Dictionary<Type, DescriptorHandlerSuite>>(() =>
            HandlerSuiteSets.Instance.For_Descriptors
                .ToDictionary(x => x.Type)
        );

        IDictionary<Type, DescriptorHandlerSuite> For_Descriptors_ByType => For_Descriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, DescriptorHandlerSuite>> For_Descriptors_ByTypeName_Lazy = new Lazy<Dictionary<string, DescriptorHandlerSuite>>(() =>
            HandlerSuiteSets.Instance.For_Descriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        IDictionary<string, DescriptorHandlerSuite> For_Descriptors_ByTypeName => For_Descriptors_ByTypeName_Lazy.Value;

        #endregion
    }
}
