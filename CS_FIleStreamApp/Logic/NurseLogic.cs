using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_FIleStreamApp.Models;
using System.Text.Json;


namespace CS_FIleStreamApp.Logic
{
    public class NurseLogic : IDisposable
    {     
        FileStream fs;
        string filePath = string.Empty;
        public NurseLogic()
        {
            filePath = @"C:\Files\data.txt";
        }

        public void WriteFile(Nurse nurse)
        {
            try
            {
                fs = new FileStream(filePath, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                var doctorsJSONData = JsonSerializer.Serialize(nurse);
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
                    Nurse nurs = new Nurse();
                    nurs.StaffId = id;
                    Console.WriteLine("Enter StaffName");
                    nurs.StaffName = Console.ReadLine();
                    Console.WriteLine("Enter Email");
                    nurs.Email = Console.ReadLine();
                    Console.WriteLine("Enter Contactno.");
                    nurs.ContactNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter dob");
                    nurs.Dob = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enetr Staff Category");
                    nurs.staff_category = Console.ReadLine();
                    Console.WriteLine("Enter Education");
                    nurs.Education = Console.ReadLine();
                    Console.WriteLine("Enter ShiftStartTime");
                    nurs.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Specialization");
                    nurs.ShiftEndTime = nurs.ShiftEndTime1(nurs.ShiftStartTime);
                    nurs.Specialization = Console.ReadLine();
                    Console.WriteLine("Enter Fees");
                    nurs.Fees = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Patient attended");
                    nurs.patientsattended = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Basicpay");
                    nurs.BasicPay = Convert.ToInt32(Console.ReadLine());

                    var data1 = JsonSerializer.Serialize<Nurse>(nurs);

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
    

