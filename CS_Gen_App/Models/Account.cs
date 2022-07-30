using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gen_App.Models
{
    public class Account
    {
        public decimal GetStaffIncome(StaffLogicAbstract staff)
        {
            decimal NetIncome = staff.CalculateIncome() - staff.ShareToHospital() - staff.Tax();
            return NetIncome;
        }

        public decimal GetTax(StaffLogicAbstract staff) 
        {
            return staff.Tax();
        }

        public decimal GetBasicPay(StaffLogicAbstract staff)
        { 
            return staff.CalculateIncome1();
        }

        public decimal HospitalShare(StaffLogicAbstract staff) 
        {
            return staff.ShareToHospital();
        }

        public decimal GrossInsome(StaffLogicAbstract staff) 
        {
            return staff.CalculateIncome(); 
        }
    }
}
