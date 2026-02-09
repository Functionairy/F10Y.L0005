using System;


namespace F10Y.L0005.L004.T000
{
    public static class Instances
    {
        public static IDescriptorOperator DescriptorOperator => T000.DescriptorOperator.Instance;
        public static L0000.IGuidOperator GuidOperator => L0000.GuidOperator.Instance;
        public static L0000.IHashCodeOperator HashCodeOperator => L0000.HashCodeOperator.Instance;
        public static L0000.IStringOperator StringOperator => L0000.StringOperator.Instance;
    }
}