using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    public class Bank
    {
        private string _bankName;
        private IList<Account> _accounts = new List<Account>();
        private static Random _rng = new Random();

        public string BankName
        {
            get
            {
                return _bankName;
            }
        }

        public Bank()
        {
            _bankName = "Undefined";
        }

        public Bank(string name)
        {
            _bankName = name;
        }

        public string CreateAccount()
        {
            //Create random account number
            //Not a valid IBAN!
            string accountNumber = "FI";
            for (int i = 0; accountNumber.Length < 18; i++)
            {
                accountNumber += (i == 0) ? _rng.Next(1, 10) : _rng.Next(0, 10);
            }

            //Create new account
            _accounts.Add(new Account(accountNumber));

            return accountNumber;
        }

        public void AddTransaction(string accountNumber, decimal sum, DateTime timeStamp)
        {
            Account targetAccount = _accounts.First(account => account.AccountNumber.Equals(accountNumber));
            targetAccount.AddTransaction(sum, timeStamp);
        }

        public string GetTransactions(string accountNumber)
        {
            Account targetAccount = _accounts.First(account => account.AccountNumber.Equals(accountNumber));
            return targetAccount.GetTransactions();
        }

        public string GetTransactions(string accountNumber, DateTime startDate, DateTime endDate)
        {
            Account targetAccount = _accounts.First(account => account.AccountNumber.Equals(accountNumber));
            return targetAccount.GetTransactions(startDate, endDate);
        }

        public decimal GetBalance(string accountNumber)
        {
            Account targetAccount = _accounts.First(account => account.AccountNumber.Equals(accountNumber));
            return targetAccount.GetBalance();
        }
    }
}
