using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using CS_FIleStreamApp.Logic;
using CS_FIleStreamApp.Models;

namespace CS_FIleStreamApp.Search
{
    public class search : IDisposable
    {
        FileStream fs;
        string filePath = string.Empty;
        public search()
        {
            filePath = @"C:\Files\data.txt";
        }
        public void searchbycat()
        {
            Console.WriteLine("Enter Category");
            string input = Console.ReadLine().ToLower();
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string line = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    var a = JsonSerializer.Deserialize<Staff>(line);
                    if (a.staff_category == input && input == "doctor")
                    {
                        var b = JsonSerializer.Deserialize<Doctor>(line);
                        Console.Write($"{b.StaffId} {b.StaffName} {b.staff_category} {b.Email} {b.Education} {b.Specialization}");
                        Console.WriteLine();
                    }
                    else if (a.staff_category == input && input == "nurse")
                    {
                        var b = JsonSerializer.Deserialize<Nurse>(line); ;
                        Console.Write($"{b.StaffId} {b.StaffName} {b.staff_category} {b.Email} {b.Education} {b.Specialization} {b.patientsattended}");
                        Console.WriteLine();
                    }
                    else if (a.staff_category == input && input == "technician")
                    {
                        var b = JsonSerializer.Deserialize<Technician>(line); ;
                        Console.Write($"{b.StaffId} {b.StaffName} {b.staff_category} {b.Email} {b.Education} {b.Specialization}");
                        Console.WriteLine();
                    }
                }
                sr.Close();
                sr.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void searchbyId()
        {   
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string line = string.Empty;
                Console.WriteLine("Enter Id");
                int input = Convert.ToInt32(Console.ReadLine());
                while ((line = sr.ReadLine()) != null)
                {
                    var data = JsonSerializer.Deserialize<Staff>(line);
                    if (data.StaffId == input && data.staff_category == "doctor")
                    {
                        var b = JsonSerializer.Deserialize<Doctor>(line);
                        Console.Write($"{b.StaffId} {b.StaffName} {b.staff_category} {b.Email} {b.Education} {b.Specialization}");
                        Console.WriteLine();
                    }
                    else if (data.StaffId == input && data.staff_category == "nurse")
                    {
                        var b = JsonSerializer.Deserialize<Nurse>(line); ;
                        Console.Write($"{b.StaffId} {b.StaffName} {b.staff_category} {b.Email} {b.Education} {b.Specialization} {b.patientsattended}");
                        Console.WriteLine();
                    }
                    else if (data.StaffId == input && data.staff_category == "technician") 
                    {
                        var b = JsonSerializer.Deserialize<Technician>(line); ;
                        Console.Write($"{b.StaffId} {b.StaffName} {b.staff_category} {b.Email} {b.Education} {b.Specialization}");
                        Console.WriteLine();
                    }

                }
                sr.Close();
                sr.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Doctor addDoctor(int id) 
        {
            Doctor doc = new Doctor();
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

            return doc;
        }
        public Nurse addNurse(int id) 
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

            return nurs;
        }
        public Technician addTechnician(int id) 
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
            Console.WriteLine("Enter Expertise");
            tech.Expertise = Console.ReadLine();
            Console.WriteLine("Enter Basic pay");
            tech.BasicPay = Convert.ToInt32(Console.ReadLine());

            return tech;
        }
        public void updatebyid()
        {
            Console.WriteLine("Enter Id to be updated");
            int id = Convert.ToInt32(Console.ReadLine());
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
                else if(data.staff_category == "doctor")
                {
                    var data1 = JsonSerializer.Serialize<Doctor>(addDoctor(id));

                    li.Add(data1);
                }
                else if (data.staff_category == "nurse")
                {
                    var data1 = JsonSerializer.Serialize<Nurse>(addNurse(id));

                    li.Add(data1);
                }
                else if (data.staff_category == "technician")
                {
                    var data1 = JsonSerializer.Serialize<Technician>(addTechnician(id));

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
        public void delete()
        {
            fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            Console.WriteLine("Enter id to be deleted");
            int id = Convert.ToInt32(Console.ReadLine());
            string line = string.Empty;

            List<String> li = new List<String>();
            while ((line = sr.ReadLine()) != null)
            {
                var data = JsonSerializer.Deserialize<Staff>(line);
                if (data.StaffId != id)
                {
                    li.Add(line);
                }
            }
            sr.Close();
            sr.Dispose();
            File.Delete(filePath);
            fs.Dispose();
            fs = new FileStream(filePath, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            foreach (var v in li)
            {
                //var data = JsonSerializer.Serialize(v);
                sw.WriteLine(v);
            }
            sw.Close();
            sw.Dispose();
        }
        public void getdetailsbycount() 
        {
            Console.WriteLine("Enter Count of details to print");
            int count = Convert.ToInt32(Console.ReadLine());
            fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = string.Empty;
                while ((line = sr.ReadLine()) != null && count > 0)
                {
                    var a = JsonSerializer.Deserialize<Staff>(line);
                    if (a.staff_category == "doctor")
                    {
                        var b = JsonSerializer.Deserialize<Doctor>(line);
                        Console.Write($"{b.StaffId} {b.StaffName} {b.staff_category} {b.Email} {b.Education} {b.Specialization}");
                        Console.WriteLine();
                    }
                    else if (a.staff_category == "nurse")
                    {
                        var b = JsonSerializer.Deserialize<Nurse>(line); ;
                        Console.Write($"{b.StaffId} {b.StaffName} {b.staff_category} {b.Email} {b.Education} {b.Specialization} {b.patientsattended}");
                        Console.WriteLine();
                    }
                    else if (a.staff_category == "technician")
                    {
                        var b = JsonSerializer.Deserialize<Technician>(line); ;
                        Console.Write($"{b.StaffId} {b.StaffName} {b.staff_category} {b.Email} {b.Education} {b.Specialization}");
                        Console.WriteLine();
                    }
                    count -= 1;
                }
        }

        public void Dispose()
        {
            fs.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
