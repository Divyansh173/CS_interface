using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Inheritence.Models;


namespace CS_Inheritence.Logic
{
    public class NurseLogic : IDisposable
    {
        FileStream fs;
        string filePath = string.Empty;
        public NurseLogic()
        {
            filePath = @"C:\Files\data.txt";
        }
        List<Nurse> Nurses = new List<Nurse>();

        public void WriteFile(Nurse nurse)
        {
            try
            {
                fs = new FileStream(filePath, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write($"Id: {nurse.StaffId} Name: {nurse.StaffName} staffcat: {nurse.staff_category}  Email: {nurse.Email} ShiftStartTime: {nurse.ShiftStartTime} ShiftEndTime: {nurse.ShiftEndTime} Specialization: {nurse.Specialization} Fees: {nurse.Fees} Education: {nurse.Education} ConatctNo: {nurse.ContactNo} Dob: {nurse.Dob}");
                sw.Write(Environment.NewLine);
                sw.Close();
                sw.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            fs.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
    

