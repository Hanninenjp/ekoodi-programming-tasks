using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi
{
    namespace Utilities
    {
        public class ReferenceNumber
        {
            private string reference;

            public string Reference
            {
                get
                {
                    return reference;
                }
            }

            public ReferenceNumber()
            {
                reference = String.Empty;
            }

            public bool IsValid()
            {
                return isValid(reference);
            }

            //Think about parameter naming!
            public static bool IsValid(string reference)
            {
                return isValid(reference);
            }

            private static bool isValid(string reference)
            {
                //Note: check reference format before conversion!
                //Not an empty string, all digits, valid length
                IList<int> digits = toDigits(reference);
                int validCheckDigit = getCheckDigit(digits.Take(digits.Count() - 1).ToList());
                int currentCheckDigit = digits.Last();
                //Console.WriteLine("Valid check digit: {0}", validCheckDigit);
                //Console.WriteLine("Current check digit: {0}", currentCheckDigit);
                if (currentCheckDigit == validCheckDigit)
                {
                    return true;
                }
                else
                {
                    return false;
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

            public static string GetCheckDigit(string reference)
            {
                IList<int> digits = toDigits(reference);
                int checkDigit = getCheckDigit(digits);
                return checkDigit.ToString();
            }

            private static IList<int> toDigits(string reference)
            {
                //Exception handling could be added
                return reference.Select(c => int.Parse(c.ToString())).ToList();
            }

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

        public static class ReferenceCreator
        {
            private static int referenceIncrement = 1;

            public static string GetReference(string basepart)
            {
                //Create single reference number
                return ReferenceNumber.CreateReference(basepart);
            }

            public static IList<string> GetReference(string basepart, int count)
            {
                //Create list of sequential reference numbers
                IList<string> referenceNumbers = new List<string>();
                for (int i = 0; i < count; i++)
                {
                    string sequentialReferenceBody = basepart + referenceIncrement.ToString();
                    string referenceNumber = ReferenceNumber.CreateReference(sequentialReferenceBody);
                    //Console.WriteLine("ReferenceCreator:GetReference:Reference number: {0}", referenceNumber);
                    referenceNumbers.Add(referenceNumber);
                    referenceIncrement++;
                }
                return referenceNumbers;
            }

        }

    }
}
