using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Utilities
{
    public class BankBarcode
    {
        private string _barcode;

        public string Barcode
        {
            get
            {
                return _barcode;
            }
        }

        public BankBarcode()
        {
            _barcode = String.Empty;
        }

        public BankBarcode(IBAN iban, BankReference reference, Decimal sum, DateTime date)
        {
            if (reference is NationalReference)
            {
                //Barcode symbol version 4 with IBAN and national reference
                _barcode = buildBarcode4(iban, reference, sum, date);
            }
            else if (reference is InternationalReference)
            {
                //Barcode symbol version 5 with IBAN and international reference
                _barcode = buildBarcode5(iban, reference, sum, date);
            }
            else
            {
                throw new ArgumentException("Bank barcode creation failed:\nUnsupported reference type!");
            }
        }

        public override string ToString()
        {
            return _barcode;
        }

        private static string buildBarcode4(IBAN iban, BankReference reference, Decimal sum, DateTime date)
        {
            decimal maxSum = (decimal)999999.99;
            string barcode = String.Empty;
            barcode += "4"; //Version 4
            barcode += iban.Iban.Substring(2);
            if (sum >= 0)
            {
                //Current implementation sets sum to 0 if the sum exceeds the supported range [0-999999.99]
                barcode += sum > maxSum ? "00000000" : sum.ToString("000000.00").Replace(",", String.Empty);
            }
            else
            {
                //Sum cannot be negative
                throw new ArgumentException(String.Format("Bank barcode creation failed:\nInvalid sum: {0}", sum));
            }
            barcode += "000"; //Reserved
            barcode += reference.Reference.PadLeft(20, '0');
            barcode += date.ToString("yyMMdd");
            return barcode;
        }

        private static string buildBarcode5(IBAN iban, BankReference reference, Decimal sum, DateTime date)
        {
            decimal maxSum = (decimal)999999.99;
            string barcode = String.Empty;
            barcode += "5"; //Version 5
            barcode += iban.Iban.Substring(2);
            if (sum >= 0)
            {
                //Current implementation sets sum to 0 if the sum exceeds the supported range [0-999999.99]
                barcode += sum > maxSum ? "00000000" : sum.ToString("000000.00").Replace(",", String.Empty);
            }
            else
            {
                //Sum cannot be negative
                throw new ArgumentException(String.Format("Bank barcode creation failed:\nInvalid sum: {0}", sum));
            }
            barcode += "000"; //Reserved
            barcode += reference.Reference.Substring(2, 2) + reference.Reference.Substring(4).PadLeft(21, '0');
            barcode += date.ToString("yyMMdd");
            return barcode;
        }
    }
}
