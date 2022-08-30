using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_FIleStreamApp.Models;
using System.Text.Json;
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

        public void updatebyid()
        {
            fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter the id you want to upadte");
            int id = Convert.ToInt32(Console.ReadLine());
            string line = string.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                //string str = sr.ReadLine();
                if (line.Contains("doctor"))
                {
                    if (line.Contains($"Id: {id} "))
                    {
                        Doctor doctor = new Doctor();
                        Console.WriteLine("Enter StaffName");
                        doctor.StaffName = Console.ReadLine();
                        Console.WriteLine("Enter Email");
                        doctor.Email = Console.ReadLine();
                        Console.WriteLine("Enter staff category");
                        doctor.staff_category = Console.ReadLine();
                        Console.WriteLine("Enter Contact No");
                        doctor.ContactNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Education");
                        doctor.Education = Console.ReadLine();
                        Console.WriteLine("Enter date of birth");
                        doctor.Dob = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Enter ShiftStartTime");
                        doctor.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter ShiftEndTime");
                        doctor.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter BasicPay");
                        doctor.BasicPay = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Specialization");
                        doctor.Specialization = Console.ReadLine();
                        Console.WriteLine("Enter Fees");
                        doctor.Fees = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter MaxPatientsperday");
                        doctor.MaxPatientsPerDay = Convert.ToInt32(Console.ReadLine());
                        //sr.Close();
                        //sr.Dispose();
                        sw.Write($"Id: {doctor.StaffId} Name: {doctor.StaffName} staffcat: {doctor.staff_category} Email: {doctor.Email} ShiftStartTime: {doctor.ShiftStartTime} ShiftEndTime: {doctor.ShiftEndTime} Specialization: {doctor.Specialization} Fees: {doctor.Fees} Education: {doctor.Education} ConatctNo: {doctor.ContactNo} Dob: {doctor.Dob}");
                        sw.Close();
                        sw.Dispose();
                        break;
                    }
                }
                else 
                {
                    Console.WriteLine("Invalid Id");
                }

            }

        }



        public void Dispose()
        {
            fs.Dispose();
            GC.SuppressFinalize(this);
        }
    }   
}
