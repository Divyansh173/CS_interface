using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace ConcurrentProject
{
    public class Account
    {
        public static ConcurrentDictionary<int, Account> AccountInfo = new ConcurrentDictionary<int, Account>();

        public int AccountNo { get; set; }

        public string? AccountName { get; set;}

        public int OpeningBalance { get; set; }

        public string? TransactiionType { get; set; }

        public int TransactionAmount { get; set; }

        public int NetBalance { get; set; }
    }
  
}
