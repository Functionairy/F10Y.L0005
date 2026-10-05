using System;
using System.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0005
{
    /// <summary>
    /// 
    /// </summary>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    [FunctionsMarker]
    public partial interface ICharacterOperator :
        L0000.ICharacterOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.ICharacterOperator _L0000 => L0000.CharacterOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        string Display(char character)
        {
            return character switch
            {
                ' ' => @"\space",
                '\t' => @"\t",
                '\n' => @"\n",
                '\r' => @"\r",
                _ => character.ToString()
            };
        }

        string DisplayCharacters(string @string)
        {
            var output = @string
                .Select(this.Display)
                .Join();

            return output;
        }
    }
}
