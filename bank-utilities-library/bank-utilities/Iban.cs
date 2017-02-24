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

        //Conversion dictionary for IBAN characters
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
            //Validity check and exception handling could be implemented here
            //or this could be a private constructor
            //https://msdn.microsoft.com/en-us/library/kcfb85a6.aspx
            //Private constructors are used to prevent creating instances of a class
            //when there are no instance fields or methods, such as the Math class, or
            //when a method is called to obtain an instance of a class.
            //!!!
            //This needs further attention!
            //!!!
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
            if (!hasValidFormat(iban))
            {
                return false;
            }
            else
            {
                //!!!
                //This is just for Finnish format and shall be rewritten!!!
                //!!!
                string countryCode = iban.Substring(0, 2);
                string checkDigits = iban.Substring(2, 2);
                string accountNumber = iban.Substring(4, 14);
                string checkString = string.Empty;
                foreach (char character in accountNumber)
                {
                    //Convert possible characters to digits, there may be characters in IBAN account number part
                    if (Char.IsLetter(character))
                    {
                        checkString += characterConversions[character.ToString()];
                    }
                    else
                    {
                        checkString += character.ToString();
                    }
                }
                foreach (char character in countryCode)
                {
                    //Convert characters to digits, also possible digits are handled
                    if (Char.IsLetter(character))
                    {
                        checkString += characterConversions[character.ToString()];
                    }
                    else
                    {
                        checkString += character.ToString();
                    }
                }
                checkString += checkDigits;

                //Just for testing
                //Console.WriteLine("Validate, checkString: {0}", checkString);

                decimal checkNumber = 0;
                if (!Decimal.TryParse(checkString, out checkNumber))
                {
                    return false;
                }
                if ((checkNumber % 97) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private static bool hasValidFormat(string iban)
        {
            //Format check for length
            if (iban.Length != 18)
            {
                return false;
            }
            else
            {
                //Format check for characters
                foreach (char character in iban)
                {
                    if (Char.IsLetter(character))
                    {
                        if (!characterConversions.ContainsKey(character.ToString()))
                        {
                            //No conversion for character exists

                            //Test printout
                            //Console.WriteLine("Failed hasValidFormat: no conversion for character!");

                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }
}
