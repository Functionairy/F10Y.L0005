using System;

using F10Y.T0002;


namespace F10Y.L0005.L004.T000
{
    [FunctionsMarker]
    public partial interface IDescriptorOperator
    {
        bool Are_Equal(
            Descriptor a,
            Descriptor b)
        {
            var output = true
                && Instances.GuidOperator.Are_Equal(
                    a.Identity,
                    b.Identity)
                && Instances.StringOperator.Are_Equal(
                    a.Name,
                    b.Name)
                && Instances.StringOperator.Are_Equal(
                    a.Description,
                    b.Description)
                ;

            return output;
        }

        int Get_HashCode(Descriptor descriptor)
            => Instances.HashCodeOperator.Get_HashCode(
                descriptor.Identity,
                descriptor.Name,
                descriptor.Description);

        Descriptor From(
            string name,
            string description,
            Guid identity)
        {
            var output = new Descriptor
            {
                Description = description,
                Identity = identity,
                Name = name,
            };

            return output;
        }

        Descriptor From(
            string name,
            string description,
            string identity)
        {
            var identity_Guid = Instances.GuidOperator.From(identity);

            var output = this.From(
                name,
                description,
                identity_Guid);

            return output;
        }

        Guid Get_Identity(string identityString)
            => Instances.GuidOperator.From(identityString);
    }
}
