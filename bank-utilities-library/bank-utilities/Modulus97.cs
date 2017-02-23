using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Utilities
{
    public static class Modulus97
    {
        public static string GetCheckDigits(string digits)
        {
            //Calculates ISO Modulo 97-10 checksum
            //Used in IBAN and international bank reference number
            decimal digitsValue = decimal.Parse(digits);
            int checkSum = 98 - (int)(digitsValue % 97);
            //Console.WriteLine("Modulo:GetMod97CheckSum:checkSum: {0}", checkSum);
            return checkSum.ToString("D2");
        }

        public static bool ValidateCheckDigits(string digits)
        {
            //Performs ISO Modulo 97-10 validation
            //Decimal supports 28-29 significant digits
            //Validating longer strings would require using another type
            //Especially possible validation of non-Finnish IBAN numbers requires attention
            decimal digitsValue = decimal.Parse(digits);
            return ((digitsValue % 97) == 1);
        }
    }
}
