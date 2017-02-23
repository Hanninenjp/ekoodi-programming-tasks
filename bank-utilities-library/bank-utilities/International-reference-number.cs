using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Utilities
{
    public class InternationalReferenceNumber
    {
        private string _reference;

        public string Reference
        {
            get
            {
                return _reference;
            }
        }

        public InternationalReferenceNumber()
        {
            _reference = String.Empty;
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
                string referenceIdentifier = reference.Substring(0, 2);
                string checkDigits = reference.Substring(2, 2);
                string referenceSequence = reference.Substring(4);
                string checkSequence = referenceSequence + referenceIdentifier + checkDigits;
                string digitSequence = String.Empty;
                //International reference number may contain both upper and lower case characters
                //Case is insignificant for the validation
                //Conversion is done in upper case
                if (CharacterConverter.Convert(checkSequence.ToUpper(), out digitSequence))
                {
                    //Console.WriteLine("Check string: {0}", digitSequence);
                    return Modulus97.ValidateCheckDigits(digitSequence);
                }
            }
            return false;
        }

        private static bool hasValidFormat(string reference)
        {
            //Format is specified in ISO 11649
            //Format checking rules should be checked against the standard
            //Now identifier, characters and length are checked
            string referenceIdentifier = "RF";
            if (!reference.HasPrefix(referenceIdentifier))
            {
                return false;
            }
            else if (!reference.IsValidRfCharacters())
            {
                return false;
            }
            else if (reference.Length < 5 || reference.Length > 25)
            {
                //Shall include a reference number (at least one digit) and shall not exceed the maximum length (25 characters)
                return false;
            }
            else
            {
                return true; 
            }
        }

        public static string CreateReference(string reference)
        {
            string referenceIdentifier = "RF";
            string alphanumericSequence = reference + referenceIdentifier + "00";
            string digitSequence = String.Empty;
            //!!!
            //Error handling
            //!!!
            CharacterConverter.Convert(alphanumericSequence, out digitSequence);
            string checkDigits = Modulus97.GetCheckDigits(digitSequence);
            string internationalReference = referenceIdentifier + checkDigits + reference;
            return internationalReference;
        }
    }
}
