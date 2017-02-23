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
            //Error handling is largely missing
            //Class structure is likely to change from application point of view
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
                Console.WriteLine("\nValid: {0}", InternationalReferenceNumber.IsValid(internationalReference));
            }
            else if (option == "2")
            {
                Console.Write("\nEnter national creditor reference basepart: ");
                string referenceBasepart = Console.ReadLine();
                string nationalReference = ReferenceCreator.GetReference(referenceBasepart);
                string internationalReference = InternationalReferenceNumber.CreateReference(nationalReference);
                Console.WriteLine("\nCreditor reference: {0}", internationalReference);
                Console.WriteLine("Valid: {0}", InternationalReferenceNumber.IsValid(internationalReference));
            }
            else
            {
                Console.WriteLine("\nNot a valid option!");
            }

            Console.WriteLine("\nPress Enter to exit!");
            Console.ReadLine();
        }


        /*
        Console.WriteLine("Development framework for international bank reference number generator!");

        //Create Finnish bank reference number
        Console.Write("\nEnter reference number basepart: ");
        string basepart = Console.ReadLine();
        string referenceNumber = ReferenceCreator.GetReference(basepart);
        Console.WriteLine("\nReference number: {0}", referenceNumber);

        //Create international bank reference number
        string internationalReference = InternationalReferenceNumber.CreateReference(referenceNumber);
        Console.WriteLine("International reference number: {0}", internationalReference);

        //Validate
        Console.WriteLine("Valid: {0}", InternationalReferenceNumber.IsValid(internationalReference));

        Console.WriteLine("\nPress Enter to exit!");
        Console.ReadLine();
        */
    }
}
