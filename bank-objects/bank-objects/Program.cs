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
            //Increase window height to 40 rows
            Console.WindowHeight = 40;
            //Set window title
            Console.Title = "Bank objects test framework";
            Console.WriteLine("Bank objects test framework!");

            //Create bank
            Bank bank = new Bank("Savings bank");

            //Create customers
            //!!!
            //Customers are currently fully known by the test application only!
            //Bank does not store Customer(s), but Account(s)
            //Account(s) does not store Customer(s) either, but account numbers 
            //This is interpreted to be according to the assignment, but may not be an optimal solution
            //!!!
            IList<Customer> customers = new List<Customer>();
            customers.Add(new Customer("John", "Smith", bank.CreateAccount()));
            customers.Add(new Customer("Jane", "Smith", bank.CreateAccount()));
            customers.Add(new Customer("Mark", "Smith", bank.CreateAccount()));

            foreach (Customer customer in customers)
            {
                //Display customer information
                Console.WriteLine(customer.ToString());

                //Generate transactions
                DateTime transactionsStartDate = new DateTime(2017, 1, 1);
                DateTime transactionsEndDate = new DateTime(2017, 2, 28);
                TransactionGenerator.GenerateTransactions(bank, customer.AccountNumber, transactionsStartDate, transactionsEndDate);
                
                //Display all transactions and current account balance
                Console.WriteLine(bank.GetTransactions(customer.AccountNumber));

                //Display transactions by time frame and starting and ending account balance
                DateTime queryStartDate = new DateTime(2017, 2, 1);
                DateTime queryEndDate = new DateTime(2017, 2, 28);
                Console.WriteLine(bank.GetTransactions(customer.AccountNumber, queryStartDate, queryEndDate));

                //Display current account balance
                Console.WriteLine("Current balance: {0:F2} EUR", bank.GetBalance(customer.AccountNumber));
            }

            Console.WriteLine("\nPress any key to exit!");
            Console.ReadKey();
        }
    }
}
