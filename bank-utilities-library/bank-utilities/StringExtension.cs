using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Utilities
{
    public static class StringExtension
    {
        public static bool IsDigits(this string s)
        {
            return !String.IsNullOrEmpty(s) && s.All(Char.IsDigit);
        }

        public static bool IsLatinAlphanumerics(this string s)
        {
            return !String.IsNullOrEmpty(s) && s.All(CharExtension.IsLatinAlphanumeric);
        }

        public static bool IsLowerLatinAlphanumerics(this string s)
        {
            return !String.IsNullOrEmpty(s) && s.All(CharExtension.IsLowerLatinAlphanumeric);
        }

        public static bool IsUpperLatinAlphanumerics(this string s)
        {
            return !String.IsNullOrEmpty(s) && s.All(CharExtension.IsUpperLatinAlphanumeric);
        }

        public static bool IsLatinLetters(this string s)
        {
            return !String.IsNullOrEmpty(s) && s.All(CharExtension.IsLatinLetter);
        }

        public static bool HasPrefix(this string s, string prefix)
        {
            return !String.IsNullOrEmpty(s) && !String.IsNullOrEmpty(prefix) && s.Length >= prefix.Length && prefix.Equals(s.Substring(0, prefix.Length));
        }
    }
}
