using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Utilities
{
    public class InternationalReference:BankReference
    {
        private string _reference;

        public override string Reference
        {
            get
            {
                return _reference;
            }
        }

        public InternationalReference()
        {
            _reference = String.Empty;
        }

        public InternationalReference(string reference)
        {
            //Exception handling could be implemented
            /*
            if (InternationalReference.IsValid(reference))
            {
                _reference = reference;
            }
            else
            {
                throw new FormatException("Reference creation failed due to invalid reference!");
            }
            */
            _reference = reference;
        }

        public override string ToString()
        {
            //Print format is also needed, coudl be another method!
            //!!!
            //Now just returns the unformatted string!
            //!!!
            return _reference;
        }

        public override string ToPrint()
        {
            //Temporary
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
                string referenceIdentifier = reference.Substring(0, 2);
                string checkDigits = reference.Substring(2, 2);
                string referenceSequence = reference.Substring(4);
                string checkSequence = referenceSequence + referenceIdentifier + checkDigits;
                string digitSequence = String.Empty;
                //International reference number may contain both upper and lower case characters
                //From validation point of view case is insignificant, digit values are the same for upper and lower case
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
                //Shall include a reference (at least one alphanumeric) and shall not exceed the maximum length (25 characters)
                return false;
            }
            else
            {
                return true; 
            }
        }

        public static BankReference CreateReference(BankReference reference)
        {
            //There is currently no format check and error handling,
            //currently always created from other reference that is assumed to be valid!
            string referenceIdentifier = "RF";
            string alphanumericSequence = reference.Reference + referenceIdentifier + "00";
            string digitSequence = String.Empty;
            CharacterConverter.Convert(alphanumericSequence, out digitSequence);
            string checkDigits = Modulus97.GetCheckDigits(digitSequence);
            string referenceSequence = referenceIdentifier + checkDigits + reference.Reference;
            return new InternationalReference(referenceSequence);
        }
    }
}
