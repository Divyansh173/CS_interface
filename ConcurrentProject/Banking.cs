using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace ConcurrentProject
{
    public class Banking
    {

        public void CreateAccount(string AccountName, int OpeningAmount)
        {
            Account account = new Account();
            account.AccountName = AccountName;
            Random random = new Random();

            int AccountNumber = random.Next(1, 100);
            bool flag = false;
            while (true) {
                foreach (var v in Account.AccountInfo)
                {
                    if (v.Key == AccountNumber) 
                    {
                        flag = true;    
                    }
                }
                if (flag)
                {
                    AccountNumber = random.Next(0, 100);
                }
                else 
                {
                    account.AccountNo = AccountNumber;
                    break;
                }

            }
            account.OpeningBalance = OpeningAmount;
            account.NetBalance = OpeningAmount;

            Account.AccountInfo.TryAdd(account.AccountNo,account);

        }
    }
}
