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
        private string _accountBalance;
        IList<Transaction> _transactions = new List<Transaction>();

        //Methods:
        //Get all transactions
        //Get transactions by time frame
        //Get account balance
        //Add transaction
    }
}
