using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ekoodi.Utilities;

namespace referencenumber_fi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bank Reference Number Calculator");
                Console.WriteLine("Validates and creates Finnish bank reference numbers");
                Console.WriteLine();
                Console.WriteLine("1. Validate reference number");
                Console.WriteLine("2. Create reference number");
                Console.WriteLine("3. Create sequence of bank reference numbers");
                Console.WriteLine();
                Console.Write("Select option: ");
                string option = Console.ReadLine();
                Console.WriteLine();
                if (option == "1")
                {
                    Console.Write("Enter reference number: ");
                    string referenceNumber = Console.ReadLine();
                    Console.WriteLine("\nValid: {0}", NationalReference.IsValid(referenceNumber));
                }
                else if (option == "2")
                {
                    Console.Write("Enter reference number basepart: ");
                    string referenceBasepart = Console.ReadLine();
                    BankReference reference = ReferenceCreator.GetReference(referenceBasepart);
                    Console.WriteLine("\nReference number: {0}", reference.ToString());
                }
                else if (option == "3")
                {
                    Console.Write("Enter reference number basepart: ");
                    string referenceBasepart = Console.ReadLine();
                    Console.Write("Enter number of reference numbers: ");
                    int referenceCount = 0;
                    try
                    {
                        referenceCount = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        throw new FormatException("Invalid number!");
                    }
                    IList<BankReference> references = ReferenceCreator.GetReferenceList(referenceBasepart, referenceCount);
                    Console.WriteLine("\nReference numbers:");
                    int element = 1;
                    foreach (BankReference reference in references)
                    {
                        Console.WriteLine("{0}. {1}", element, reference.ToString());
                        element++;
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid option!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n{0}", e.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
