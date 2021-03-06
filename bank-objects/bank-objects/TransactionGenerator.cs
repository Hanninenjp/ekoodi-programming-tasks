﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_objects
{
    public static class TransactionGenerator
    {
        private static Random _rng = new Random();

        public static void GenerateTransactions(Bank bank, string accountNumber, DateTime startDate, DateTime endDate)
        {
            DateTime timeStamp = startDate;
            while (timeStamp <= endDate)
            {
                //Deposit
                TransactionGenerator.processDeposit(bank, accountNumber, timeStamp);
                //Payments
                for (int i = 0; i < 10; i++)
                {
                    int dayIncrement = _rng.Next(1, 6);
                    if (timeStamp.Day + dayIncrement < DateTime.DaysInMonth(timeStamp.Year, timeStamp.Month))
                    {
                        timeStamp = timeStamp.AddDays(dayIncrement).AddHours(_rng.Next(0, 24)).AddMinutes(_rng.Next(0, 60)).AddSeconds(_rng.Next(0, 60));
                        TransactionGenerator.processPayment(bank, accountNumber, timeStamp);
                    }
                    else
                    {
                        break;
                    }
                }
                //Next month
                int nextMonth = timeStamp.Month == 12 ? 1 : timeStamp.Month + 1;
                int nextYear = timeStamp.Month == 12 ? timeStamp.Year + 1 : timeStamp.Year;
                timeStamp = new DateTime(nextYear, nextMonth, 1);
            }
        }

        //Deposit
        public static void processDeposit(Bank bank, string accountNumber, DateTime timeStamp)
        {
            //Generate random deposit [1800,00-2800,00] EUR
            bank.AddTransaction(accountNumber, _rng.Next(1800, 2801), timeStamp);
        }

        //Payment
        public static void processPayment(Bank bank, string accountNumber, DateTime timeStamp)
        {
            //Generate random payment [1,00-199,99] EUR
            decimal paymentSum = -((decimal)_rng.Next(1, 200) + (decimal)_rng.Next(0, 100) / 100);
            bank.AddTransaction(accountNumber, paymentSum, timeStamp);
        }
    }
}
