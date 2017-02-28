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

            //Display customer information
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }

            //Generate transactions
            foreach (Customer customer in customers)
            {
                DateTime startDate = new DateTime(2017, 1, 1);
                DateTime endDate = DateTime.Now;
                TransactionGenerator.GenerateTransactions(bank, customer.AccountNumber, startDate, endDate);
            }

            //Display all transactions and account balance
            foreach (Customer customer in customers)
            {
                Console.WriteLine(bank.GetTransactions(customer.AccountNumber));
                Console.WriteLine("Account balance: {0:F2} EUR", bank.GetBalance(customer.AccountNumber));
            }

            //Display transactions by time frame and account balance
            foreach (Customer customer in customers)
            {
                DateTime startDate = new DateTime(2017, 2, 1);
                DateTime endDate = DateTime.Now;
                Console.WriteLine(bank.GetTransactions(customer.AccountNumber, startDate, endDate));
                Console.WriteLine("Account balance: {0:F2} EUR", bank.GetBalance(customer.AccountNumber));
            }

            //Display customer information and account balance
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ToString());
                Console.WriteLine("Account balance: {0:F2} EUR", bank.GetBalance(customer.AccountNumber));
            }

            Console.WriteLine("\nPress any key to exit!");
            Console.ReadKey();
        }
    }
}
