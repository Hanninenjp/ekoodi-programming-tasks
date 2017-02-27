using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank objects test framework!");
            Bank bank = new Bank("Savings bank");
            IList<Customer> customers = new List<Customer>();
            customers.Add(new Customer("John", "Smith", bank.CreateAccount()));
            customers.Add(new Customer("Jane", "Smith", bank.CreateAccount()));
            customers.Add(new Customer("Mark", "Smith", bank.CreateAccount()));
            
            foreach(Customer customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }
            
            foreach (Customer customer in customers)
            {
                bank.AddTransaction(customer.AccountNumber, 100, new DateTime());
            }

            foreach (Customer customer in customers)
            {
                Console.WriteLine(bank.GetTransactions(customer.AccountNumber));
            }
                        
            Console.WriteLine("\nPress any key to exit!");
            Console.ReadKey();
        }
    }
}
