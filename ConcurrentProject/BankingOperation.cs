using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentProject
{
    public class BankingOperation
    {

        public void Opertaion(Account account, BankingTransaction banking) 
        {
            Random random = new Random();
            int number = random.Next(1, 1);
            if (number == 1)
            {
                Task task = Task.Factory.StartNew(() =>
                {
                    banking.Deposit(account);
                });
                // task.Wait();
                Task task1 = Task.Factory.StartNew(() =>
                {
                    banking.Withdrawal(account);
                }
               );
                Task.WaitAll(task, task1);

                //Parallel.Invoke(() =>
                //{
                //    banking.Deposit(account);
                //    banking.Withdrawal(account);
                //}
                //);
            }
            else if (number == 2)
            {
                Task task = Task.Factory.StartNew(() =>
                {
                    banking.Deposit(account);
                });
                task.Wait();
            }
            else
            {
                Task task = Task.Factory.StartNew(() =>
                {
                    banking.Withdrawal(account);
                }
                );
                task.Wait();
            }
        }
    }
}
