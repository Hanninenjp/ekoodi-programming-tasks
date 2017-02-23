using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Utilities
{
    public static class CharExtensionBanking
    {
        public static bool IsValidBbanCharacter(char c)
        {
            //Digits, spaces and separator '-'
            return Char.IsDigit(c) || c.Equals(' ') || c.Equals('-');
        }

        public static bool IsValidIbanCharacter(char c)
        {
            //Upper latin alphanumerics (digits and upper latin letters)
            return CharExtension.IsUpperLatinAlphanumeric(c);
        }

        public static bool IsValidRfCharacter(char c)
        {
            //Latin alphanumerics (digits and latin letters)
            return CharExtension.IsLatinAlphanumeric(c);
        }
    }
}
