using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;

using F10Y.L0005.L004.T000;


namespace F10Y.L0005.L004
{
    [FunctionsMarker]
    public partial interface IDescriptorHandlers
    {
        bool Are_Equal(
            Descriptor a,
            IDescriptor b)
            => Instances.TypeOperator.If_TypeIs_ElseFalse(
                a,
                b,
                this.Are_Equal);

        bool Are_Equal(Descriptor a, Descriptor b)
            => Instances.DescriptorOperator.Are_Equal(a, b);

        int Get_HashCode(Descriptor descriptor)
            => Instances.DescriptorOperator.Get_HashCode(descriptor);

        Descriptor Get_Descriptor(Descriptor descriptor)
            => descriptor;

        IEnumerable<string> To_Text_ContentOnly(Descriptor descriptor)
        {
            var ID = Instances.GuidOperator.To_String_ForDescriptor(descriptor.Identity);

            var output = Instances.EnumerableOperator.From(
                $"{descriptor.Name} ({ID})",
                descriptor.Description
            );

            return output;
        }

        IEnumerable<string> To_Text(Descriptor descriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(descriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(descriptor);

            var output = Instances.EnumerableOperator.From($"Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
