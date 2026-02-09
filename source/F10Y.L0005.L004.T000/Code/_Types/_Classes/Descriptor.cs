using System;

using F10Y.L0005.T001;


namespace F10Y.L0005.L004.T000
{
    public class Descriptor : IDescriptor,
        IEquatable<Descriptor>,
        IWith_Identity_AsGuid,
        IWith_Name,
        IWith_Description
    {
        public Guid Identity { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is Descriptor applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(Descriptor other)
            => Instances.DescriptorOperator.Are_Equal(
                this,
                other);

        public override int GetHashCode()
            => Instances.DescriptorOperator.Get_HashCode(this);
    }
}
