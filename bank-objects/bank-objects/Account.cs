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
            //Console.WriteLine("\nAccount:AddTransaction:Transaction:Sum: {0}", sum);
            //Console.WriteLine("\nAccount:AddTransaction:Transaction:Timestamp: {0}", timeStamp);
            return;
        }

        public string GetTransactions()
        {
            string transactions = String.Format("\nAccount number: {0}\nAccount transactions (all):", _accountNumber);
            foreach (Transaction t in _transactions)
            {
                transactions += t.ToString();
            }
            return transactions;
        }

        public string GetTransactions(DateTime startDate, DateTime endDate)
        {
            string transactions = String.Format("\nAccount number: {0}\nAccount transactions ({1:dd.MM.yy}-{2:dd.MM.yy}:)", _accountNumber, startDate, endDate);
            /*
            IEnumerable<Transaction> query = from t in _transactions
                                       where startDate <= t.TimeStamp
                                       select t;
            */                          
            IList<Transaction> transactionsList = _transactions.Where(t => t.TimeStamp >= startDate && t.TimeStamp <= endDate).ToList();
            foreach (Transaction t in transactionsList)
            {
                transactions += t.ToString();
            }
            transactions += String.Format("\nStart balance: {0} EUR\nEnd balance: {1} EUR", transactionsList.First().OldBalance, transactionsList.Last().NewBalance);
            return transactions;
        }

        public decimal GetBalance()
        {
            return _accountBalance;
        }

        //Methods:
        //XGet all transactions
        //XGet transactions by time frame
        //!Get account balance
        //XAdd transaction

    }
}
