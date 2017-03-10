using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Utilities
{
    public class IBAN
    {
        private string _iban;
        private bool _isValid;

        public string Iban
        {
            get
            {
                return _iban;
            }
        }

        public IBAN()
        {
            _iban = "Not defined";
            _isValid = false;
        }

        public IBAN(string iban)
        {
            //Validity check and exception handling could be implemented
            _iban = iban;
            _isValid = true;
        }

        public override string ToString()
        {
            return _iban;
        }

        public string ToPrint()
        {
            string printFormatIban = String.Empty;
            if (!_isValid)
            {
                printFormatIban = "Not defined";
                return printFormatIban;
            }
            else
            {
                int index = 0;
                foreach (char character in _iban)
                {
                    if (index != 0 && index % 4 == 0)
                    {
                        printFormatIban += " " + character;
                    }
                    else
                    {
                        printFormatIban += character;
                    }
                    index++;
                }
                return printFormatIban;
            }
        }

        public static IBAN Parse(string iban)
        {
            if (IBAN.isValid(iban))
            {
                return new IBAN(iban);
            }
            else
            {
                throw new ArgumentException("Invalid input!");
            }
        }

        public bool IsValid()
        {
            return isValid(_iban);
        }

        public static bool IsValid(string iban)
        {
            return isValid(iban);
        }

        private static bool isValid(string iban)
        {
            if (hasValidFormat(iban))
            {
                string ibanCountryCode = iban.Substring(0, 2);
                string ibanCheckDigits = iban.Substring(2, 2);
                string ibanBban = iban.Substring(4);
                string checkSequence = ibanBban + ibanCountryCode + ibanCheckDigits;
                string digitSequence = String.Empty;
                if (CharacterConverter.Convert(checkSequence, out digitSequence))
                {
                    //Console.WriteLine("\nCheck string: {0}", checkSequence);
                    //Console.WriteLine("\nValidation string: {0}", digitSequence);
                    return Modulus97.ValidateCheckDigits(digitSequence);
                }
            }
            return false;
        }

        private static bool hasValidFormat(string iban)
        {

            //Validation is currently supported for the Finnish IBAN format only
            //Furthermore, validation does not currently support checking the Finnish BBAN check digit
            string ibanIdentifier = "FI";
            if (!iban.HasPrefix(ibanIdentifier))
            {
                return false;
            }
            else if (iban.Length != 18)
            {
                return false;
            }
            else if (!iban.IsValidIbanCharacters())
            {
                return false;
            }
            else if (!iban.Substring(4).IsDigits())
            {
                //Finnish BBAN shall contain digits only
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
