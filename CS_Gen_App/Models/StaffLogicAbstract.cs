using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gen_App.Models
{
    public abstract class StaffLogicAbstract 
    {
        protected decimal BasicPay = 0;

        public virtual decimal CalculateIncome1()
        {
            return this.BasicPay = 0;
        }

        public abstract decimal CalculateIncome();
        public abstract decimal ShareToHospital();

        public abstract decimal Tax();
    }

    public class DoctorLogicEx : StaffLogicAbstract//, IAccount<Staff, int>
    {
        private int PatientsDiagonsed = 0;
        private int OperationsPerDay = 0;

        private decimal TotalIncome = 0;

        public DoctorLogicEx(int id, int patientsDiagonsed, int operationsPerDay)
        {
            PatientsDiagonsed = patientsDiagonsed;
            OperationsPerDay = operationsPerDay;
        }

        /// <summary>
        /// OVerrding Method
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateIncome1()
        {
            int BasicPay = 10000;
            return BasicPay;
        }
        public override decimal CalculateIncome()
        {
            decimal operationFees = OperationsPerDay * 30 * 10000;
            decimal patientsFessReceived = PatientsDiagonsed * 30 * 500;
            // Call BAse CLass Implementation to ger return value
            TotalIncome = CalculateIncome1() + operationFees + patientsFessReceived;
            return TotalIncome;
        }
        public override decimal ShareToHospital()
        {
            return TotalIncome * Convert.ToDecimal(0.2);
        }

        public override decimal Tax()
        {
            return TotalIncome * Convert.ToDecimal(0.18);
        }
    }


    public class NurseLogicEx : StaffLogicAbstract
    {
        private decimal InjectionApplied = 0;
        private decimal PatientsMonitored = 0;

        private decimal GrossIncome = 0;


        public NurseLogicEx(int id, decimal injectionApplied, decimal patientsMonitored)
        {
            InjectionApplied = injectionApplied;
            PatientsMonitored = patientsMonitored;
        }
        public override decimal CalculateIncome1()
        {
            int BasicPay = 5000;
            return BasicPay;
        }

        public override decimal CalculateIncome()
        {
            decimal duetyFees = PatientsMonitored * 250;
            decimal injecionFees = InjectionApplied * 60;
            GrossIncome = CalculateIncome1() + duetyFees + injecionFees;
            return GrossIncome;
        }

        public override decimal ShareToHospital()
        {
            return GrossIncome * Convert.ToDecimal(0.05);
        }

        public override decimal Tax()
        {
            return GrossIncome * Convert.ToInt32(0.18);
        }
    }
}

