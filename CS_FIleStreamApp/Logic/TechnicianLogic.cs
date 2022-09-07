using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_FIleStreamApp.Models;
using System.Text.Json;

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

        public void WriteFile(Technician technician)
        {
            try
            {
                fs = new FileStream(filePath, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                var doctorsJSONData = JsonSerializer.Serialize(technician);
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
            while ((line = sr.ReadLine()) != null)
            {
                var data = JsonSerializer.Deserialize<Staff>(line);
                if (data.StaffId != id)
                {
                    li.Add(line);
                }
                else
                {
                    Technician tech = new Technician();
                    tech.StaffId = id;
                    Console.WriteLine("Enter StaffName");
                    tech.StaffName = Console.ReadLine();
                    Console.WriteLine("Enter Email");
                    tech.Email = Console.ReadLine();
                    Console.WriteLine("Enter Contactno.");
                    tech.ContactNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter dob");
                    tech.Dob = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enetr Staff Category");
                    tech.staff_category = Console.ReadLine();
                    Console.WriteLine("Enter Education");
                    tech.Education = Console.ReadLine();
                    Console.WriteLine("Enter ShiftStartTime");
                    tech.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
                    tech.ShiftEndTime = tech.ShiftEndTime1(tech.ShiftStartTime);
                    Console.WriteLine("Enter Specialization");
                    tech.Specialization = Console.ReadLine();
                    Console.WriteLine("Enter Fees");
                    tech.Specialization = Console.ReadLine();
                    Console.WriteLine("Enter MaxPatientsPerDay");
                    tech.Expertise = Console.ReadLine();
                    Console.WriteLine("Enter Basic pay");
                    tech.BasicPay = Convert.ToInt32(Console.ReadLine());

                    var data1 = JsonSerializer.Serialize<Technician>(tech);

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
            //fs.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
