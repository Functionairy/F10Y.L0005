using System;


namespace F10Y.L0005.L002
{
    public static class Instances
    {
        public static L0000.IDefaultOperator DefaultOperator => L0000.DefaultOperator.Instance;
        public static IServiceCollectionOperator ServiceCollectionOperator => L002.ServiceCollectionOperator.Instance;
        public static IServiceProviderOperator ServiceProviderOperator => L002.ServiceProviderOperator.Instance;
        public static IServicesOperator ServicesOperator => L002.ServicesOperator.Instance;
    }
}