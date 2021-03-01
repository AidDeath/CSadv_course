using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11._CSadv_Threading
{
    class BankAccount
    {
        private double _balance;
        public BankAccount()
        {
            _balance = 0;
        }
        private static object block = new object();
        public double AccState()
        {
            return _balance;
        }

        //Приход
        public void Debit(double debit)
        {
            Monitor.Enter(block);
            try
            {
                _balance += debit;
                Console.WriteLine($"Put {debit}");
            }
            finally
            {
                Monitor.Exit(block);
            }
        }
        //Расход
        public void Credit(double credit)
        {
            Monitor.Enter(block);
            try
            {
                _balance -= credit;
                Console.WriteLine($"Withdraw {credit}");
            }
            finally
            {
                Monitor.Exit(block);
            }
            
        }
    }
}
