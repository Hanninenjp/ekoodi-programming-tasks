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

        //Methods:
        //Create account, creates account and returns account number
        //Get all account transactions by account
        //Get account transactions by time frame by account
        //Get account balance by account
        //Add transaction by account

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
            //Luo pankkiin jokaiselle asiakkaalle oma pankkitili.
            //Pankkiin luodun tilin tilinumero palautetaan ja talletetaan asiakas-olion muuttujaan.
            //Tee tilinumerosta 18 merkkiä pitkä.
            //Kaksi ensimmäistä merkkiä ovat 'FI'.Generoi loput merkit käyttäen C#:n Random-luokkaa.

            //Create random account number
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
            //Console.WriteLine("\nBank:AddTransaction:Target account: {0}", targetAccount.AccountNumber);
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
