using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    class Bank
    {
        private string _bankName;
        private IList<Account> _accounts = new List<Account>();

        //Methods:
        //Create account, creates and returns account number
        //Get all account transactions by account
        //Get account transactions by time frame by account
        //Get account balance by account
        //Add transaction by account
    }
}
