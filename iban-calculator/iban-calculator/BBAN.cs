using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iban_calculator
{
    public class BBAN
    {
        private string bankAccountNumber;
        
        public string BankAccountNumber
        {
            get
            {
                return bankAccountNumber;
            }
            /*
            set
            {
                //Consider, if set is required, perhaps not
                //Use this or separate set
            }
            */
        }

        public BBAN ()
        {
            bankAccountNumber = "Not defined";
        }

        public static string ParseAccountNumber (string userInput)
        {
            //Parse account number from user input, return account number

            //Remove any spaces and '-', ignore possible other format errors in the content
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
                    //Probably inefficient, StringBuilder could be used instead
                    //However, there are not many iterations
                    accountNumber += character.ToString();
                }
            }

            //Check for format errors, content has to be all digits and length between 8 and 14 digits
            if(!accountNumber.All(Char.IsDigit))
            {
                //Format error, content
                //Just for testing, add exception handling!
                Console.WriteLine("Format error, content!");
            }
            else if (accountNumber.Length < 8 || accountNumber.Length > 14)
            {
                //Format error, length
                //Just for testing, add exception handling!
                Console.WriteLine("Format error, length!");
            }

            //!!!
            //Note: above error handling does not check for leading zeroes!
            //!!!

            //Create machine format account number by adding zeroes according to the following formatting rules

            /*
            1 = Nordea Pankki (Nordea)
            2 = Nordea Pankki (Nordea)
            31 = Handelsbanken
            33 = Skandinaviska Enskilda Banken (SEB)
            34 = Danske Bank
            36 = Tapiola Pankki
            37 = DnB NOR Bank ASA (DnB NOR)
            38 = Swedbank
            39 = S-Pankki
            4 = Aktia Pankki, Säästöpankit (Sp) ja Paikallisosuuspankit (POP)
            5 = OP-Pohjola-ryhmä (Osuuspankit (OP), Helsingin OP Pankki ja Pohjola Pankki)
            6 = Ålandsbanken ÅAB)
            8 = Sampo Pankki

            Nordea, Handelsbanken, SEB, Danske Bank, Tapiola Pankki, DnB NOR, Swedbank, S-Pankki, ÅAB ja Sampo Pankki

            Näiden pankkien tilinumerot täydennetään nollilla vasemmalta lukien kuuden numeron jälkeen siten, että 14 numeroa täyttyy.

            Aktia Pankki, Säästöpankit (Sp), Paikallisosuuspankit (POP) ja OPPohjola-ryhmä (osuuspankit (OP), Helsingin OP Pankki ja Pohjola Pankki

            Näiden pankkien tilinumerot täydennetään nollilla vasemmalta lukien seitsemännen numeron jälkeen siten, että 14 numeroa täyttyy.
            */

            //Just a quick version, with no check for valid financial institution specific codes
            //!!!
            //Consider reworking this part!
            //!!!
            if (accountNumber.ToCharArray().GetValue(0).Equals('4') || accountNumber.ToCharArray().GetValue(0).Equals('5'))
            {
                //Insert zeroes after 7th digit, until length is 14
                Console.WriteLine("Insert after 7th digit!");
                while (accountNumber.Length < 14)
                {
                    accountNumber = accountNumber.Insert(7, "0");
                }
            }
            else
            {
                //Insert zeroes after 6th digit, until length is 14
                Console.WriteLine("Insert after 6th digit!");
                while (accountNumber.Length < 14)
                {
                    accountNumber = accountNumber.Insert(6, "0");
                }
            }

            //Return machine format account number
            return accountNumber;
}

public bool SetAccountNumber (string accountNumber)
{
            if (!ValidateAccountNumber(accountNumber))
            {
                //!!!
                //Consider exception handling!
                //!!!
                return false;
            }
            else
            {
                bankAccountNumber = accountNumber;
            }
            return true;
}

private static bool ValidateAccountNumber (string accountNumber)
{
//Validate account number format and check digit
return true;
}



}
}
