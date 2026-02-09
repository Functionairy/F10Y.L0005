using System;


namespace F10Y.L0005.L003
{
    public static class Instances
    {
        public static IExceptionMessageOperator ExceptionMessageOperator => L003.ExceptionMessageOperator.Instance;
        public static IExceptionOperator ExceptionOperator => L003.ExceptionOperator.Instance;
        public static L0000.ITypeOperator TypeOperator => L0000.TypeOperator.Instance;
    }
}