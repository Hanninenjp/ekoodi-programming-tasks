using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Utilities
{
    public class NationalReference:BankReference
    {
        private string _reference;

        public override string Reference
        {
            get
            {
                return _reference;
            }
        }

        public NationalReference()
        {
            _reference = String.Empty;
        }

        public NationalReference(string reference)
        {
            //Exception handling could be implemented
            _reference = reference;
        }

        public override string ToString()
        {
            //Print or barcode format, based on format specifier?
            //!!!
            //Now just returns the unformatted string!
            //!!!
            return _reference;
        }

        public bool IsValid()
        {
            return isValid(_reference);
        }

        public static bool IsValid(string reference)
        {
            return isValid(reference);
        }

        private static bool isValid(string reference)
        {
            if (hasValidFormat(reference))
            {
                IList<int> digits = toDigits(reference);
                int validCheckDigit = getCheckDigit(digits.Take(digits.Count() - 1).ToList());
                int currentCheckDigit = digits.Last();
                //Console.WriteLine("Valid check digit: {0}", validCheckDigit);
                //Console.WriteLine("Current check digit: {0}", currentCheckDigit);
                if (currentCheckDigit == validCheckDigit)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        private static bool hasValidFormat(string reference)
        {
            if (!reference.IsDigits())
            {
                return false;
            }
            else if (reference.Length < 4 || reference.Length > 20)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static string CreateReference(string basepart)
        {
            //Note: check basepart format before conversion!
            //Console.WriteLine("ReferenceNumber:CreateReference:Basepart: {0}", basepart);
            string referenceNumber = basepart + GetCheckDigit(basepart);
            //Console.WriteLine("ReferenceNumber:CreateReference:Reference number: {0}", referenceNumber);
            return referenceNumber;
        }

        //Could be moved to separate modulus 731 or something like that class
        //Then there could also be separate get and validate, like with modulus 97
        public static string GetCheckDigit(string reference)
        {
            IList<int> digits = toDigits(reference);
            int checkDigit = getCheckDigit(digits);
            return checkDigit.ToString();
        }

        //Could be moved to modulus 731 class
        private static IList<int> toDigits(string reference)
        {
            //Exception handling could be added
            return reference.Select(c => int.Parse(c.ToString())).ToList();
        }

        //Could be moved to modulus 731 class
        private static int getCheckDigit(IList<int> digits)
        {
            int[] weights = { 7, 3, 1 };
            int weightedSum = 0;
            int j = 0;
            foreach (int digit in digits.Reverse())
            {
                weightedSum += digit * weights[j % 3];
                //Console.WriteLine("ReferenceNumber:getCheckDigit:Digit: {0}", digit);
                //Console.WriteLine("ReferenceNumber:getCheckDigit:Weight selector: {0}", j);
                //Console.WriteLine("ReferenceNumber:getCheckDigit:Weight: {0}", weights[j % 3]);
                //Console.WriteLine("ReferenceNumber:getCheckDigit:Weighted sum: {0}", weightedSum);
                j++;
            }
            int checkDigit = (10 - (weightedSum % 10)) % 10;
            //Console.WriteLine("ReferenceNumber:getCheckDigit:Checkdigit: {0}", checkDigit);
            return checkDigit;
        }
    }
}
