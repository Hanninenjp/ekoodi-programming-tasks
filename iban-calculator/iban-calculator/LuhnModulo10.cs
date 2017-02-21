using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iban_calculator
{
    public static class LuhnModulo10
    {

        private static readonly Dictionary<int, int> weightedDigitValues = new Dictionary<int, int>
        {
            { 0, 0 }, { 1, 2 },
            { 2, 4 }, { 3, 6 },
            { 4, 8 }, { 5, 1 },
            { 6, 3 }, { 7, 5 },
            { 8, 7 }, { 9, 9 }
        };

        private static int CheckDigit(IList<int> digits)
        {
            var i = 0;
            var lengthMod = digits.Count % 2;
            //This is not very readable, consider rewriting
            return (digits.Sum(d => i++ % 2 == lengthMod ? d : weightedDigitValues[d]) * 9) % 10;
        }

        private static bool HasValidCheckDigit(IList<int> digits)
        {
            return digits.Last() == CheckDigit(digits.Take(digits.Count - 1).ToList());
        }

        private static IList<int> ToDigitList(string digits)
        {
            return digits.Select(d => d - 48).ToList();
            //Alternatively: return digits.Select(d => int.Parse(d.ToString())).ToList();

        }

        public static bool HasValidCheckDigit(string digits)
        {
            if (!digits.All(Char.IsDigit))
            {
                return false;
            }
            else
            {
                IList<int> digitList = ToDigitList(digits);
                /*
                foreach (int digit in digitList)
                {
                    Console.WriteLine("Luhn, digits: {0}", digit);
                }
                */
                return HasValidCheckDigit(digitList);
            }
        }

        public static string GetCheckDigit (string digits)
        {
            IList<int> digitList = ToDigitList(digits);
            return Convert.ToString(CheckDigit(digitList.Take(digitList.Count - 1).ToList()));
        }

        public static string AppendCheckDigit (string digits)
        {
            IList<int> digitList = ToDigitList(digits);
            return digits + Convert.ToString(CheckDigit(digitList.Take(digitList.Count - 1).ToList()));
        }

    }
}