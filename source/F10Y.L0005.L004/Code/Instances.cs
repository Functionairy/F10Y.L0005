using System;


namespace F10Y.L0005.L004
{
    public static class Instances
    {
        public static IDescriptorHandlers DescriptorHandlers => L004.DescriptorHandlers.Instance;
        public static IDescriptorOperator DescriptorOperator => L004.DescriptorOperator.Instance;
        public static L0000.IEnumerableOperator EnumerableOperator => L0000.EnumerableOperator.Instance;
        public static IGuidOperator GuidOperator => L004.GuidOperator.Instance;
        public static IHandlerSuiteSets HandlerSuiteSets => L004.HandlerSuiteSets.Instance;
        public static L0000.ITypeNameOperator TypeNameOperator => L0000.TypeNameOperator.Instance;
        public static L0001.L004.ITypeOperator TypeOperator => L0001.L004.TypeOperator.Instance;
        public static ITypeSpecifiers TypeSpecifiers => L004.TypeSpecifiers.Instance;
    }
}