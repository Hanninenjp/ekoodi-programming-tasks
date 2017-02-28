using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    public class Transaction
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

        public override string ToString()
        {
            return String.Format("\nSum: {0:F2} EUR, Date: {1:dd.MM.yy}, Time: {2:HH:mm:ss}", _sum, _timeStamp, _timeStamp);
        }
    }
}
