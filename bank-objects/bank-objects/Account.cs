using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    class Account
    {
        private string _accountNumber;
        private decimal _accountBalance;
        IList<Transaction> _transactions = new List<Transaction>();

        public string AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }

        public decimal AccountBalance
        {
            get
            {
                return _accountBalance;
            }
        }

        public Account()
        {
            _accountNumber = "Undefined";
            _accountBalance = 0;
        }

        public Account(string number)
        {
            _accountNumber = number;
            _accountBalance = 0;
        }

        public void AddTransaction(decimal sum, DateTime timeStamp)
        {
            _transactions.Add(new Transaction(sum, timeStamp));
            _accountBalance += sum;
            Console.WriteLine("\nAccount:AddTransaction:Transaction:Sum: {0}", sum);
            return;
        }

        public string GetTransactions()
        {
            string transactions = String.Format("\nAccount: {0}\nAccount transactions:", _accountNumber);
            foreach (Transaction t in _transactions)
            {
                //ToString needs to be overridden!
                transactions += String.Format("{0}", t.ToString());
            }
            return transactions;
        }

        //Methods:
        //Get all transactions
        //Get transactions by time frame
        //Get account balance
        //XAdd transaction

    }
}
