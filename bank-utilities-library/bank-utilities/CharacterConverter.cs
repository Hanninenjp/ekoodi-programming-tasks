using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Utilities
{
    public static class CharacterConverter
    {
        //Dictionary for converting IBAN and international bank reference number characters to their numeric value
        private static readonly Dictionary<string, string> characterConversions = new Dictionary<string, string>
        {
            { "A", "10" }, { "B", "11" }, { "C", "12" }, { "D", "13" },
            { "E", "14" }, { "F", "15" }, { "G", "16" }, { "H", "17" },
            { "I", "18" }, { "J", "19" }, { "K", "20" }, { "L", "21" },
            { "M", "22" }, { "N", "23" }, { "O", "24" }, { "P", "25" },
            { "Q", "26" }, { "R", "27" }, { "S", "28" }, { "T", "29" },
            { "U", "30" }, { "V", "31" }, { "W", "32" }, { "X", "33" },
            { "Y", "34" }, { "Z", "35" }
        };

        public static bool Convert(string alphanumerics, out string digits)
        {
            digits = String.Empty;
            foreach (char character in alphanumerics)
            {
                if (Char.IsDigit(character))
                {
                    //No conversion needed
                    digits += character.ToString();
                }
                else
                {
                    //Conversion is needed
                    if (characterConversions.ContainsKey(character.ToString()))
                    {
                        digits += characterConversions[character.ToString()];
                    }
                    else
                    {
                        //Exception handling could be implemented
                        digits = string.Empty;
                        return false;
                    }
                }
            }
            //Console.WriteLine("CharacterConversion:Digits: {0}", digits);
            return true;
        }
    }
}
