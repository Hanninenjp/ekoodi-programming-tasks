using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Utilities
{
    public static class StringExtensionBanking
    {
        public static bool IsValidBbanCharacters(this string s)
        {
            return !String.IsNullOrEmpty(s) && s.All(CharExtensionBanking.IsValidBbanCharacter);
        }

        public static bool IsValidIbanCharacters(this string s)
        {
            return !String.IsNullOrEmpty(s) && s.All(CharExtensionBanking.IsValidIbanCharacter);
        }

        public static bool IsValidRfCharacters(this string s)
        {
            return !String.IsNullOrEmpty(s) && s.All(CharExtensionBanking.IsValidRfCharacter);
        }
    }
}
