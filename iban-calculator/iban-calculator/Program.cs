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

            Console.WriteLine("IBAN Calculator");
            Console.WriteLine("Converts Finnish basic bank account number to IBAN");
            Console.WriteLine();

            // Read BAN from user
            Console.Write("Enter an account number: ");
            string userInput = Console.ReadLine();
            Console.WriteLine();

            BBAN bban = new BBAN();

            if (!bban.ParseFromInput(userInput))
            {
                Console.WriteLine("Account number format is incorrect!");
            }
            else
            {
                Console.WriteLine("BBAN: {0}", bban.BasicBAN);
                Console.WriteLine("BBAN check digit is valid: {0}", bban.HasValidCheckDigit());
                IBAN iban = new IBAN();
                iban.SetIBAN(bban.ToIBAN());
                Console.WriteLine("IBAN in machine inface format: {0}", iban.InternationalBAN);
                Console.WriteLine("IBAN in human interface format: {0}", iban.ToHumanFormat());
                Console.WriteLine("IBAN check digits are valid: {0}", iban.IsValidIBAN());
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
