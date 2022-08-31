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
       //List<Doctor> Doctors = new List<Doctor>();

        public void WriteFile(Doctor doctor)
        {
            try
            {
                //Doctors.Add(doctor);
                fs = new FileStream(filePath,FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                //sw.Write($"Id: {doctor.StaffId} Name: {doctor.StaffName} staffcat: {doctor.staff_category} Email: {doctor.Email} ShiftStartTime: {doctor.ShiftStartTime} ShiftEndTime: {doctor.ShiftEndTime} Specialization: {doctor.Specialization} Fees: {doctor.Fees} Education: {doctor.Education} ConatctNo: {doctor.ContactNo} Dob: {doctor.Dob}") ;
                var doctorsJSONData = JsonSerializer.Serialize(doctor);
                //Console.WriteLine($"Data \n {doctorsJSONData}");
                sw.Write(doctorsJSONData);
                sw.Write(Environment.NewLine);
                sw.Close();
                sw.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updatebyid(int id)
        {
            fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            //StreamWriter sw = new StreamWriter(fs);
            List<Staff> li = new List<Staff>();
            string line = string.Empty;
            while ((line = sr.ReadLine()) != null) 
            {
                
                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<Staff>(line);
                if (data.StaffId != id)
                {     
                    li.Add(data);
                }
                else 
                {
                    Doctor doctor = new Doctor();
                    Console.WriteLine("Enter staff Id");
                    doctor.StaffId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("staff category");
                    doctor.staff_category = Console.ReadLine();
                    Console.WriteLine("Enter Email");
                    doctor.Email = Console.ReadLine();
                    Console.WriteLine("Enter Conatct no");
                    doctor.ContactNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Fees");
                    doctor.Fees = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Basic Pay");
                    doctor.BasicPay = Convert.ToInt32(Console.ReadLine());
                   
                    li.Add(doctor);
                    
                }
            }
            sr.Close();
            sr.Dispose(); 
            File.Delete(filePath);
            fs = new FileStream(filePath, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            foreach (var data in li)
            {
                var data1 = JsonSerializer.Serialize(data);
                sw.Write(data1);
                sw.Write(Environment.NewLine);
            }
            //sr.Close();
            //sr.Dispose();
            sw.Close();
            sw.Dispose();

        }

        public void delete() 
        {
            fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            Console.WriteLine("Enter id to be deleted");
            int id = Convert.ToInt32(Console.ReadLine());
            string line = string.Empty;

            List<Staff> li = new List<Staff>();
            while ((line = sr.ReadLine()) != null) 
            {
                var data = JsonSerializer.Deserialize<Staff>(line);
                if (data.StaffId != id) 
                {
                    li.Add(data);
                }
            }
            sr.Close();
            sr.Dispose();
            File.Delete(filePath);
            fs = new FileStream(filePath, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            foreach (var v in li) 
            {
                var data = JsonSerializer.Serialize(v);
                sw.Write(data);
                sw.Write(Environment.NewLine);
            }
            sw.Close();
            sw.Dispose();
        }



        public void Dispose()
        {
            //fs.Dispose();
            GC.SuppressFinalize(this);
        }
    }   
}
