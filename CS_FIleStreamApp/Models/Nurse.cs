using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_FIleStreamApp.Models
{
    public class Nurse : Staff
    {
        public Nurse()
        {
            //Console.WriteLine("CTOR for Doctor");
        }
        public string? Specialization { get; set; }
        public int Fees { get; set; }
        public int patientsattended { get; set; }

        //public void SetBasicPay(int pay)
        //{
        //    this.BasicPay = pay;
        //}

        //public int GetBasicPay()
        //{
        //    return this.BasicPay;
        //}

    }
}
