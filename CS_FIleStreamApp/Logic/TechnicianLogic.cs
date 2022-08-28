using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_FIleStreamApp.Models;

namespace CS_FIleStreamApp.Logic
{
    public class TechnicianLogic : IDisposable
    {
        FileStream fs;
        string filePath = string.Empty;
        public TechnicianLogic()
        {
            filePath = @"C:\Files\data.txt";
        }
        List<Technician> Technicians = new List<Technician>();

        public void WriteFile(Technician technician)
        {
            try
            {
                fs = new FileStream(filePath, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write($"Id: {technician.StaffId} Name: {technician.StaffName} staffcat: {technician.staff_category}  Email: {technician.Email} ShiftStartTime: {technician.ShiftStartTime} ShiftEndTime: {technician.ShiftEndTime} Specialization: {technician.Specialization} Education: {technician.Education} ConatctNo: {technician.ContactNo} Dob: {technician.Dob}");
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
