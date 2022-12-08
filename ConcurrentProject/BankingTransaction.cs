using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConcurrentProject
{
    public class BankingTransaction
    {
        public Account Withdrawal(Account account)
        {
            //Console.WriteLine("To Withdraw, Please enter your account number");
            //int AccountNumber = Convert.ToInt32(Console.ReadLine());
            //int user_account = 0;
            //int transaction_amount = 0;
            //int net_balance = 0;
            int TransactionAmount = 200;
            
            foreach (var v in Account.AccountInfo)
            {
               Monitor.Enter(this);
                //if (v.Key == AccountNumber)
                //{
                    //user_account = v.Key;
                //Console.WriteLine("Enter the amount to withdrawal");
               // account.TransactionAmount = TransactionAmount;
                v.Value.NetBalance -= TransactionAmount;
                Console.WriteLine(JsonSerializer.Serialize(v));
                   //transaction_amount = TransactionAmount;
                    //net_balance = v.Value.NetBalance;
                Console.WriteLine("Withdrawal");
                Monitor.Exit(this);  
                //}
            }
            
            //using (StreamWriter sw = new StreamWriter($@"C:\SalarySlip\{user_account}", true)) 
            //{
            //    sw.WriteLine($"AccountNo    Date     Time  TransactionType TransactionAmount   Balnace               ");
            //    sw.Write($"{user_account}  {DateTime.Now}  withdrwal  {transaction_amount}  {net_balance}");
            //}
            return account;
        }
       
        public Account Deposit(Account account)
        {
            //Console.WriteLine("Enter the Account Number to deposit");
            //int AccountNumber = Convert.ToInt32(Console.ReadLine());
            //int user_account = 0;
            //int transaction_amount = 0;
            //int net_balance = 0;
            int DepositAmount = 300;
            foreach (var v in Account.AccountInfo)
            {
                Monitor.Enter(this);

                //if (v.Key == AccountNumber)
                //{
                // user_account = v.Key;
                //Console.WriteLine("Enter the amount to be deposited");
                //transaction_amount = DepositAmount;
                v.Value.NetBalance += DepositAmount;
                Console.WriteLine(JsonSerializer.Serialize(v));

                // net_balance = v.Value.NetBalance;
                Console.WriteLine("Deposit");
                Monitor.Exit(this);
                //}
            }
            //using (StreamWriter sw = new StreamWriter($@"C:\SalarySlip\{user_account}", true))
            //{
            //    sw.WriteLine($"AccountNo    Date   Time  TransactionType TransactionAmount   Balnace               ");

            //    sw.Write($"{user_account}        {DateTime.Now}      Deposit     {transaction_amount}     {net_balance}");
            //}

            return account;
        }


    }
}

