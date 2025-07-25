using System;


namespace F10Y.L0005
{
    public static class Instances
    {
        public static ICharacterOperator CharacterOperator => L0005.CharacterOperator.Instance;
        public static L0000.IEnumerableOperator EnumerableOperator => L0000.EnumerableOperator.Instance;
        public static L0000.ITextOperator TextOperator => L0000.TextOperator.Instance;
    }
}