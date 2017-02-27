using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    class Customer
    {
        private string _firstName;
        private string _lastName;
        private string _accountNumber;

        public string AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }

        public Customer()
        {
            _firstName = "Undefined";
            _lastName = "Undefined";
            _accountNumber = "Undefined";
        }

        public Customer(string firstName, string lastName, string accountNumber)
        {
            _firstName = firstName;
            _lastName = lastName;
            _accountNumber = accountNumber;
        }

        public override string ToString()
        {
            return String.Format("\nCustomer: {0} {1}\nAccount number: {2}", _firstName, _lastName, _accountNumber);
        }
    }
}
