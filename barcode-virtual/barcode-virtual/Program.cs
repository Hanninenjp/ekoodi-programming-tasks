#define DEVELOPMENT
#define NATIONAL

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
                //Still under development!
                //Testing is required!
                //Better checking and error handling for the entered sum is required!
                //Exception handling may have some room for improvement
                Console.WriteLine("Virtual Bank Barcode Generator");
                Console.WriteLine("Creates Finnish virtual bank barcode");
                Console.WriteLine("Either national or internation reference can be used");

#if DEVELOPMENT
                Console.WriteLine("\nDevelopment mode: input values are populated with defaults!");
                Console.WriteLine("Press Enter in each input to proceed!");
#endif

                //Get user inputs
                Console.Write("\nEnter IBAN: ");
                string ibanInput = Console.ReadLine();
#if DEVELOPMENT
                ibanInput = "FI7650940020125924";
#endif
                IBAN iban = IBAN.Parse(ibanInput);

                Console.Write("Enter reference: ");
                string referenceInput = Console.ReadLine();
#if DEVELOPMENT
#if INTERNATIONAL
                referenceInput = "RF8512345672";
#elif NATIONAL
                referenceInput = "12345672";
#elif INVALID
                referenceInput = "ABC";
#endif
#endif
                BankReference reference = ReferenceCreator.Parse(referenceInput);

                Console.Write("Enter sum: ");
                string sumInput = Console.ReadLine();
#if DEVELOPMENT
                sumInput = "123,45";
#endif
                decimal sum = decimal.Parse(sumInput);

                Console.Write("Enter due date (DD.MM.YYYY): ");
                string dateInput = Console.ReadLine();

#if DEVELOPMENT
                dateInput = "31.03.2017";
#endif
                DateTime date = DateTime.Parse(dateInput);

                Console.WriteLine("\nIBAN: {0}", iban.ToString());
                Console.WriteLine("Reference: {0}", reference.ToString());
                Console.WriteLine("Reference type: {0}", reference.GetType());
                Console.WriteLine("Sum: {0} EUR", sum.ToString("F2"));
                Console.WriteLine("Date: {0}", date.ToString());

                BankBarcode barcode = new BankBarcode(iban, reference, sum, date);
                Console.WriteLine("\nVirtual barcode: {0}", barcode.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid input!");
                //Console.WriteLine("Barcode creation failed!");
            }
            Console.WriteLine("\nPress Enter to exit!");
            Console.ReadLine();
        }
    }
}
