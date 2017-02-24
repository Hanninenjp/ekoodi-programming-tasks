using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ekoodi.Utilities;

namespace referencenumber_international
{
    class Program
    {
        static void Main(string[] args)
        {
            //Still under development!
            //Exception handling may require further attention
            try
            {
                Console.WriteLine("Creditor Reference Calculator");
                Console.WriteLine("Validates and creates international creditor references");
                Console.WriteLine("\n1. Validate creditor reference");
                Console.WriteLine("2. Create creditor reference");
                Console.WriteLine();
                Console.Write("\nSelect option: ");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    Console.Write("\nEnter international creditor reference: ");
                    string internationalReference = Console.ReadLine();
                    Console.WriteLine("\nValid: {0}", InternationalReference.IsValid(internationalReference));
                }
                else if (option == "2")
                {
                    Console.Write("\nEnter national creditor reference basepart: ");
                    string referenceBasepart = Console.ReadLine();
                    BankReference nationalReference = ReferenceCreator.GetReference(referenceBasepart);
                    BankReference internationalReference = ReferenceCreator.GetReference(nationalReference);
                    Console.WriteLine("\nCreditor reference: {0}", internationalReference.ToString());
                    Console.WriteLine("Valid: {0}", InternationalReference.IsValid(internationalReference.Reference));
                }
                else
                {
                    Console.WriteLine("\nNot a valid option!");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\n{0}", e.Message);
            }
            Console.WriteLine("\nPress Enter to exit!");
            Console.ReadLine();
        }
    }
}
