using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Utilities
{
    public static class CharExtension
    {
        private static readonly string _lowerLatinCharacters = "abcdefghijklmnopqrstuvwxyz";
        private static readonly string _upperLatinCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static bool IsLatinAlphanumeric(char c)
        {
            return Char.IsDigit(c) || CharExtension.IsLatinLetter(c);
        }

        public static bool IsLowerLatinAlphanumeric(char c)
        {
            return Char.IsDigit(c) || CharExtension.IsLowerLatinLetter(c);
        }

        public static bool IsUpperLatinAlphanumeric(char c)
        {
            return Char.IsDigit(c) || CharExtension.IsUpperLatinLetter(c);
        }

        public static bool IsLatinLetter(char c)
        {
            return _lowerLatinCharacters.Contains(c) || _upperLatinCharacters.Contains(c);
        }

        public static bool IsLowerLatinLetter(char c)
        {
            return _lowerLatinCharacters.Contains(c);
        }

        public static bool IsUpperLatinLetter(char c)
        {
            return _upperLatinCharacters.Contains(c);
        }
    }
}
