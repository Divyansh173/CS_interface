using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_FIleStreamApp.Models;
namespace CS_FIleStreamApp.Logic
{
    public class DoctorLogic : IDisposable
    {
        FileStream fs;
        string filePath = string.Empty;
        public DoctorLogic()
        {
            filePath = @"C:\Files\data.txt";
        }
        List<Doctor> Doctors = new List<Doctor>();

        public void WriteFile(Doctor doctor)
        {
            try
            {
                fs = new FileStream(filePath,FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write($"Id: {doctor.StaffId} Name: {doctor.StaffName} staffcat: {doctor.staff_category} Email: {doctor.Email} ShiftStartTime: {doctor.ShiftStartTime} ShiftEndTime: {doctor.ShiftEndTime} Specialization: {doctor.Specialization} Fees: {doctor.Fees} Education: {doctor.Education} ConatctNo: {doctor.ContactNo} Dob: {doctor.Dob}") ;
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
            //fs.Dispose();
            GC.SuppressFinalize(this);
        }
    }   
}
