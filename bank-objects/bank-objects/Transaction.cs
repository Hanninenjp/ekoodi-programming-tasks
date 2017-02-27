using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    class Transaction
    {
        private decimal _sum;
        private DateTime _timeStamp;

        public Transaction()
        {
            _sum = 0;
            _timeStamp = new DateTime();
        }

        public Transaction(decimal sum, DateTime timeStamp)
        {
            _sum = sum;
            _timeStamp = timeStamp;
        }

        public string ToString()
        {
            return String.Format("\nSum: {0}", _sum);
            //Timestamp is not yet supported
        }
    }
}
