using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iban_calculator
{
    public class BBAN
    {
        private string basicBAN;
        private bool isValid;

        public string BasicBAN
        {
            get
            {
                return basicBAN;
            }
        }

        public BBAN()
        {
            basicBAN = string.Empty;
            isValid = false;
        }

        public bool ParseFromInput(string userInput)
        {
            //Remove any spaces and '-', ignore possible other format errors in the content
            //Format errors are currently not checked for the position or number of spaces or '-'
            string accountNumber = String.Empty;
            foreach (char character in userInput)
            {
                if (character.Equals(' ') || character.Equals('-'))
                {
                    //Iterate next element
                    continue;
                }
                else
                {
                    accountNumber += character.ToString();
                }
            }
            //Check for format errors, content has to be all digits and length has to be between 8 and 14 digits
            //Format errors are currently not checked for leading zeroes
            //Format errors are currently not checked for bank code validity
            if (!accountNumber.All(Char.IsDigit))
            {
                //Format error, content
                return false;

                //Just for testing, add exception handling!
                //Console.WriteLine("Format error, content!");
            }
            else if (accountNumber.Length < 8 || accountNumber.Length > 14)
            {
                //Format error, length
                return false;

                //Just for testing, add exception handling!
                //Console.WriteLine("Format error, length!");
            }

            //Create machine format BBAN
            //Formatting does not currently explicitly check all the bank codes
            if (accountNumber[0].Equals('4') || accountNumber[0].Equals('5'))
            {
                //Insert zeroes after 7th digit, until length is 14
                //Console.WriteLine("Insert after 7th digit!");
                while (accountNumber.Length < 14)
                {
                    accountNumber = accountNumber.Insert(7, "0");
                }
            }
            else
            {
                //Insert zeroes after 6th digit, until length is 14
                //Console.WriteLine("Insert after 6th digit!");
                while (accountNumber.Length < 14)
                {
                    accountNumber = accountNumber.Insert(6, "0");
                }
            }

            //Set BBAN
            basicBAN = accountNumber;
            isValid = true;
            return true;
        }

        public string ToIBAN()
        {
            //Convert Finnish BBAN to IBAN
            //Country code is always FI, append FI00 or in converted form 151800
            //Returns empty string, if BBAN is not valid
            //Exception handling logic could be additionally implemented

            if (!isValid)
            {
                //No valid BBAN to convert
                return String.Empty;
            }
            else
            {
                //Convert Finnish BBAN to IBAN
                string checkString = basicBAN;
                checkString += "151800";
                decimal checkNumber = 0;
                int checkDigit = 0;
                string internationalBAN = String.Empty;
                if (!Decimal.TryParse(checkString, out checkNumber))
                {
                    return internationalBAN;
                }
                //Calculate check digit
                checkDigit = 98 - (int)(checkNumber % 97);
                //Create IBAN
                internationalBAN = "FI" + checkDigit.ToString("D2") + basicBAN;
                return internationalBAN;
            }
        }

        public bool HasValidCheckDigit()
        {
            if (!isValid)
            {
                return false;
            }
            else if (!LuhnModulo10.HasValidCheckDigit(basicBAN))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
