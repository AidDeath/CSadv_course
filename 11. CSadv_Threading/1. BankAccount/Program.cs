using System;
using System.Threading;
using System.Threading.Tasks;

namespace _11._CSadv_Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            BankAccount bankAccount = new BankAccount();

            Task taskPut = new Task(put);
            Task taskWithdraw = new Task(withdraw);

            taskPut.Start();
            taskWithdraw.Start();

            void put(){
                for (int i = 0; i < 100; i++)
                    bankAccount.Debit(1000);
            }

            void withdraw()
            {
                for (int i = 0; i < 100; i++)
                    bankAccount.Credit(1000);
            }

            taskPut.Wait();
            taskWithdraw.Wait();

            Console.WriteLine("Account balance: " + bankAccount.AccState());

        }

    }
}
