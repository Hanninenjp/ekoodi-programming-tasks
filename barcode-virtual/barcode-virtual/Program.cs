using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ekoodi.Utilities;

namespace barcode_virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Virtual Bank Barcode Generator");
                Console.WriteLine("Creates Finnish virtual bank barcode");
                Console.WriteLine("Either national or internation reference can be used");

                Console.Write("\nEnter IBAN: ");
                string ibanInput = Console.ReadLine();
                IBAN iban = IBAN.Parse(ibanInput);

                Console.Write("Enter reference: ");
                string referenceInput = Console.ReadLine();
                BankReference reference = ReferenceCreator.SelectReference(referenceInput);

                Console.Write("Enter sum: ");
                string sumInput = Console.ReadLine();
                decimal sum = decimal.Parse(sumInput);

                Console.Write("Enter due date (DD.MM.YYYY): ");
                string dateInput = Console.ReadLine();
                DateTime date = DateTime.Parse(dateInput);

                Console.WriteLine("\nIBAN: {0}", iban.ToString());
                Console.WriteLine("Reference: {0}", reference.ToString());
                Console.WriteLine("Sum: {0} EUR", sum.ToString("F2"));
                Console.WriteLine("Date: {0}", date.ToString("dd.MM.yyyy"));

                BankBarcode barcode = new BankBarcode(iban, reference, sum, date);
                Console.WriteLine("\nVirtual barcode: {0}", barcode.ToString());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(String.Format("\n{0}", e.Message));
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid input!");
            }
            Console.WriteLine("\nPress Enter to exit!");
            Console.ReadLine();
        }
    }
}
