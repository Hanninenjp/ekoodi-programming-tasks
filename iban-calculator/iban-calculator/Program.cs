using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iban_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Assignment:
             * Tee C#-ohjelma (laskuri), joka muuttaa vanhanmallisen BBAN -tilinumero IBAN muotoon.
             * IBAN-laskurin käyttö Tilinumeron vanha muoto on mallia: 6 numeroa, väliviiva ja 2-8 numeroa.
             * Voit syöttää tilinumeron väliviivalla tai ilman.
             * Laskuri myös laskee syöttämäsi tilinumeron tarkisteen, joka varmistaa, että syötettu arvo on oikean mallinen.
             * Lopuksi laskuri laskee IBAN-tilinumerossa käytössä olevan tarkisteen, joka on kaksi merkkiä maakoodin jälkeen.
             */

            // Read BAN from user

            Console.Write("Enter an account number: ");
            string userInput = Console.ReadLine();
            string accountNumber = BBAN.ParseAccountNumber(userInput);

            //Test
            Console.WriteLine("Test BBAN.Parse()!");
            Console.WriteLine("User input: {0}, length: {1}", userInput, userInput.Length);
            Console.WriteLine("Parse output: {0}, length: {1}", accountNumber, accountNumber.Length);

            // Parse and check BAN, create BAN
            Console.WriteLine("Test BBAN.SetAccountNumber, get .BankAccountNumber");
            BBAN bankAccountNumber = new BBAN();
            bankAccountNumber.SetAccountNumber(accountNumber);
            Console.WriteLine("Account number is: {0}", bankAccountNumber.BankAccountNumber);

            // Create IBAN from BAN
            IBAN internationalAccountNumber = new IBAN();
            internationalAccountNumber.BuildIBAN(bankAccountNumber);

            //Print IBAN to user
            Console.WriteLine("IBAN is: {0}", internationalAccountNumber.InternationalBankAccountNumber);

            //Check IBAN
            if (!IBAN.ValidateIBAN(internationalAccountNumber))
            {
                Console.WriteLine("Invalid IBAN!");
            }
            else
            {
                Console.WriteLine("Valid IBAN!");
            }

            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
