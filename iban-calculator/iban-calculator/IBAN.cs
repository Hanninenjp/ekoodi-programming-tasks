using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iban_calculator
{
    public class IBAN
    {
        private string internationalBAN;
        private bool isValid;

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

        public string InternationalBAN
        {
            get
            {
                return internationalBAN;
            }
        }

        public IBAN()
        {
            internationalBAN = "Not defined";
            isValid = false;
        }

        public bool SetIBAN (string iban)
        {
            internationalBAN = iban;
            isValid = true;
            return true;
        }

        public string ToHumanFormat()
        {
            string humanFormatIBAN = String.Empty;
            if (!isValid)
            {
                humanFormatIBAN = "Not defined";
                return humanFormatIBAN;
            }
            else
            {
                int index = 0;
                foreach(char character in internationalBAN)
                {
                    if (index != 0 && index % 4 == 0)
                    {
                        humanFormatIBAN += " " + character;
                    }
                    else
                    {
                        humanFormatIBAN += character;
                    }
                    index++;
                }
                return humanFormatIBAN;
            }
        }

        public bool IsValidIBAN()
        {
            return isValidIBAN(internationalBAN);
        }

        public static bool IsValidIBAN (string iban)
        {
            return isValidIBAN(iban);
        }

        private static bool isValidIBAN(string iban)
        {
            if (!hasValidFormat(iban))
            {
                return false;
            }
            else
            {
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
