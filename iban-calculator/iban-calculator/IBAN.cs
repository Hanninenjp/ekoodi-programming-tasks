using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iban_calculator
{
    public class IBAN
    {
        private string internationalBankAccountNumber;

        private static readonly Dictionary<string, string> CharacterValues = new Dictionary<string, string>
        {
            { "A", "10" }, { "B", "11" }, { "C", "12" }, { "D", "13" },
            { "E", "14" }, { "F", "15" }, { "G", "16" }, { "H", "17" },
            { "I", "18" }, { "J", "19" }, { "K", "20" }, { "L", "21" },
            { "M", "22" }, { "N", "23" }, { "O", "24" }, { "P", "25" },
            { "Q", "26" }, { "R", "27" }, { "S", "28" }, { "T", "29" },
            { "U", "30" }, { "V", "31" }, { "W", "32" }, { "X", "33" },
            { "Y", "34" }, { "Z", "35" }
        };

        public string InternationalBankAccountNumber
        {
            get
            {
                return internationalBankAccountNumber;
            }
        }

        public IBAN()
        {
            internationalBankAccountNumber = "Not defined";
        }

        public bool BuildIBAN (BBAN bankAccountNumber)
        {

            /*
            Kukin IBANissa esiintyvä kirjain muunnetaan numeeriseksi oheisen taulukon avulla ennen IBANin tarkistamista.
            A = 10 G = 16 M = 22 S = 28 Y = 34
            B = 11 H = 17 N = 23 T = 29 Z = 35
            C = 12 I = 18 O = 24 U = 30
            D = 13 J = 19 P = 25 V = 31
            E = 14 K = 20 Q = 26 W = 32
            F = 15 L = 21 R = 27 X = 33

            Alkuperäinen BBAN-muotoinen tilinumero(esim. 159030 - 776) muunnetaan ensin 14 - numeroiseen konekieliseen muotoon (15903000000776).

            Kokonaisen 14-numeroisen BBAN-tilinumeron loppuun liitetään maatunnus ja kaksi nollaa(15903000000776FI00).

            Seuraavaksi tilinumeron kaikki kirjaimet, mukaan lukien maatunnukset, korvataan numeroilla siten, että A=10, B=11, ..., Z=35. (15903000000776FI00 -> 15903000000776151800).

            Näiden vaiheiden tuloksena saadusta luvusta lasketaan tarkistenumero:

            jaetaan saatu luku 97:llä
            jakojäännös vähennetään 98:sta.
            erotus on tilinumeron tarkiste(15903000000776151800 / 97, jakojäännös on 61. 98-61 = 37)
            mikäli tarkiste on pienempi kuin 10, lisätään etunolla.
            Lopuksi lisätään maatunnus sekä kaksi kaksinumeroinen tarkiste konekielisessä muodossa olevan tilinumeron eteen (FI3715903000000776).
            Tulos esitetään usein selkeyden vuoksi ryhmiteltynä(FI37 1590 3000 0007 76).
            */

            //Handle just case FI, append FI00 or in converted form 151800
            //Dictionary has been defined to validate and could be used also here
            //Console.WriteLine("FI: F={0}, I={1}", CharacterValues["F"], CharacterValues["I"]);
            string checkString = bankAccountNumber.BankAccountNumber;
            checkString += "151800";
            decimal checkNumber = 0;
            int checkDigit = 0;

            if (!Decimal.TryParse(checkString, out checkNumber))
            {
                //Failure, handle

            }

            //Calculate check digit
            checkDigit = 98 - (int)(checkNumber % 97);
            //Build and set IBAN
            internationalBankAccountNumber = "FI" + checkDigit.ToString("D2") + bankAccountNumber.BankAccountNumber;
            
            return true;
        }

        public static bool ValidateIBAN (IBAN internationalBankAccountNumber)
        {
            //!!!
            //Implementation is missing
            //Make implementation compatible with iban specification, not spefic to just Finnish iban structure
            //!!!
            string countryCode = internationalBankAccountNumber.InternationalBankAccountNumber.Substring(0, 2);
            string checkDigit = internationalBankAccountNumber.InternationalBankAccountNumber.Substring(2, 2);
            string accountNumber = internationalBankAccountNumber.InternationalBankAccountNumber.Substring(4, 14);
            string checkString = string.Empty;
            foreach (char character in accountNumber)
            {
                //Convert possible characters to digits, there may be characters in international IBANs
                if (Char.IsLetter(character))
                {
                    checkString += CharacterValues[character.ToString()];
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
                    checkString += CharacterValues[character.ToString()];
                }
                else
                {
                    checkString += character.ToString();
                }
            }
            checkString += checkDigit;

            //Just for testing
            Console.WriteLine("Validate, checkString: {0}", checkString);

            decimal checkNumber = 0;
            if (!Decimal.TryParse(checkString, out checkNumber))
            {
                //Failure, handle

            }
            if ((checkNumber % 97) == 1){
                return true;
            }
            else {
                return false;
            }
        }
    }
}
