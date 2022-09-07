using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_FIleStreamApp.Models;
using System.Text.Json;
//using Newtonsoft.Json;
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
   
        public void WriteFile(Doctor doctor)
        {
            try
            {
                fs = new FileStream(filePath,FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                var doctorsJSONData = JsonSerializer.Serialize(doctor);
                sw.Write(doctorsJSONData);
                sw.Write(Environment.NewLine);
                sw.Close();
                sw.Dispose();
                fs.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updatebyid(int id)
        {
            fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<String> li = new List<String>();
            string line = string.Empty;
            while ((line = sr.ReadLine()) != null) {
                var data = JsonSerializer.Deserialize<Staff>(line);
                if (data.StaffId != id)
                {
                    li.Add(line);
                }
                else {
                    Doctor doc = new Doctor();
                    //Console.WriteLine("Enter StaffId");
                    doc.StaffId = id;
                    Console.WriteLine("Enter StaffName");
                    doc.StaffName = Console.ReadLine();
                    Console.WriteLine("Enter Email");
                    doc.Email = Console.ReadLine();
                    Console.WriteLine("Enter Contactno.");
                    doc.ContactNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter dob");
                    doc.Dob = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enetr Staff Category");
                    doc.staff_category = Console.ReadLine();
                    Console.WriteLine("Enter Education");
                    doc.Education = Console.ReadLine();
                    Console.WriteLine("Enter ShiftStartTime");
                    doc.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
                    doc.ShiftEndTime = doc.ShiftEndTime1(doc.ShiftStartTime);
                    Console.WriteLine("Enter Specialization");
                    doc.Specialization = Console.ReadLine();
                    Console.WriteLine("Enter Fees");
                    doc.Fees = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter MaxPatientsPerDay");
                    doc.MaxPatientsPerDay = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter basic pay");
                    doc.BasicPay = Convert.ToInt32(Console.ReadLine());

                    var data1 = JsonSerializer.Serialize<Doctor>(doc);

                    li.Add(data1);
                }
            }

            sr.Close();
            sr.Dispose();
            File.Delete(filePath);
            fs = new FileStream(filePath, FileMode.Create);
            fs.Close();
            fs.Dispose();
            fs = new FileStream(filePath, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach (var item in li)
            {
                
                sw.WriteLine(item);
                
            }
            sw.Close();
            sw.Dispose();
            fs.Close();
            fs.Dispose();
            

        }

        public void Dispose()
        {
            fs.Dispose();
            GC.SuppressFinalize(this);
        }
    }   
}
