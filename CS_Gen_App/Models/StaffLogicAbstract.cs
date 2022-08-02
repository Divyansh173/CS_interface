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

        public virtual decimal Basic_Pay()
        {
            return this.BasicPay = 0;
        }

        public abstract decimal CalculateIncome();
        public abstract decimal ShareToHospital();

        public abstract decimal Tax();
    }

    public class DoctorLogicEx : StaffLogicAbstract
    {
        private int PatientsDiagonsed = 0;
        private int OperationsPerDay = 0;

        private decimal TotalIncome = 0;

        public DoctorLogicEx(int id, int patientsDiagonsed, int operationsPerDay)
        {
            PatientsDiagonsed = patientsDiagonsed;
            OperationsPerDay = operationsPerDay;
        }

        public override decimal Basic_Pay()
        {
            int BasicPay = 10000;
            return BasicPay;
        }
        public override decimal CalculateIncome()
        {
            decimal operationFees = OperationsPerDay * 30 * 10000;
            decimal patientsFessReceived = PatientsDiagonsed * 30 * 500;
            // Call BAse CLass Implementation to ger return value
            TotalIncome = Basic_Pay() + operationFees + patientsFessReceived;
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
        public override decimal Basic_Pay()
        {
            int BasicPay = 5000;
            return BasicPay;
        }

        public override decimal CalculateIncome()
        {
            decimal duetyFees = PatientsMonitored * 250;
            decimal injecionFees = InjectionApplied * 60;
            GrossIncome = Basic_Pay() + duetyFees + injecionFees;
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
    public class DriverLogicEx : StaffLogicAbstract
    {
        private decimal No_Of_Days = 0;
        private decimal GrossIncome = 0;
        public override decimal Basic_Pay()
        {
            int BasicPay = 8000;
            return BasicPay;
        }

        public DriverLogicEx(int id, decimal no_of_days) {
            No_Of_Days = no_of_days; 
        }
        public override decimal CalculateIncome()
        {
            GrossIncome = Basic_Pay() + No_Of_Days * 300;
            return GrossIncome;
        }

        public override decimal ShareToHospital()
        {
            return GrossIncome * Convert.ToInt32(0.01);
        }

        public override decimal Tax()
        {
            return GrossIncome * Convert.ToInt32(0.18);
        }
    }
}

