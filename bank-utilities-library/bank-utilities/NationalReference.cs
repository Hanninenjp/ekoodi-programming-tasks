﻿using System;
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
            return _reference;
        }

        public override string ToPrint()
        {
            string printFormat = String.Empty;
            if (!_reference.Equals(String.Empty))
            {
                int i = 0;
                foreach (char character in _reference)
                {
                    //Five digit groups from left to right
                    if (i != 0 && i % 5 == 0)
                    {
                        printFormat += " " + character;
                    }
                    else
                    {
                        printFormat += character;
                    }
                    i++;
                }
                return printFormat;
            }
            else
            {
                return String.Empty;
            }
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

        public static BankReference CreateReference(string basepart)
        {
            if (hasValidBasepartFormat(basepart))
            {
                //Leading zeroes are removed
                string referenceNumber = basepart.TrimStart('0');
                referenceNumber = basepart + GetCheckDigit(basepart);
                return new NationalReference(referenceNumber);
            }
            else
            {
                throw new FormatException("Invalid basepart!");
            }
        }

        private static bool hasValidBasepartFormat(string basepart)
        {
            if (!basepart.IsDigits())
            {
                return false;
            }
            else if (basepart.Length < 3 || basepart.Length > 19)
            {
                return false;
            }
            else
            {
                return true;
            }
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
