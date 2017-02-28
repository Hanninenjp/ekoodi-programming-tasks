using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    public class Account
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
            decimal oldBalance = _accountBalance;
            decimal newBalance = _accountBalance + sum;
            _transactions.Add(new Transaction(sum, oldBalance, newBalance, timeStamp));
            _accountBalance = newBalance;
            return;
        }

        public string GetTransactions()
        {
            string transactions = String.Format("\nAccount transactions (all):", _accountNumber);
            foreach (Transaction t in _transactions)
            {
                transactions += t.ToString();
            }
            return transactions;
        }

        public string GetTransactions(DateTime startDate, DateTime endDate)
        {
            string transactions = String.Format("\nAccount transactions ({1:dd.MM.yy}-{2:dd.MM.yy}:)", _accountNumber, startDate, endDate);
            //Alternatively:
            //IEnumerable<Transaction> query = from t in _transactions
            //                           where startDate <= t.TimeStamp
            //                           select t;
            IList<Transaction> transactionsList = _transactions.Where(t => t.TimeStamp >= startDate && t.TimeStamp <= endDate).ToList();
            foreach (Transaction t in transactionsList)
            {
                transactions += t.ToString();
            }
            transactions += String.Format("\nStart balance: {0:F2} EUR\nEnd balance: {1:F2} EUR", transactionsList.First().OldBalance, transactionsList.Last().NewBalance);
            return transactions;
        }

        public decimal GetBalance()
        {
            return _accountBalance;
        }
    }
}
