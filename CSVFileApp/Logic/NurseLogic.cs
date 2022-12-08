using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CsvHelper;
using CSVFileApp.Models;

namespace CSVFileApp.Logic
{
    public class NurseLogic
    {
        public List<Nurse> nurse = new List<Nurse>()
        {
            new Nurse() { StaffId = 1, StaffName = "sakshi", staff_category = "nurse", Email = "sakshi@Movie.com", ContactNo = 998899, Education = "bsc nursing", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "Cancer", Fees = 6456, patientsattended = 10 },
        
            new Nurse() { StaffId = 1, StaffName = "sonali", staff_category = "nurse", Email = "sonalih@Movie.com", ContactNo = 998899, Education = "anm", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "Cancer", Fees = 6456, patientsattended = 10 },
        
            new Nurse() { StaffId = 3, StaffName = "indumati", staff_category = "nurse", Email = "indumati@Movie.com", ContactNo = 998899, Education = "anm", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "Cancer", Fees = 6000, patientsattended = 10 },
       
            new Nurse() { StaffId = 4, StaffName = "kavita", staff_category = "nurse", Email = "kavita@Movie.com", ContactNo = 998899, Education = "bsc nursing", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "Cancer", Fees = 6236, patientsattended = 10 },
        
            new Nurse() { StaffId = 5, StaffName = "rashika", staff_category = "nurse", Email = "rashika@Movie.com", ContactNo = 998899, Education = "anm", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "Cancer", Fees = 7896, patientsattended = 10 },
        
            new Nurse() { StaffId = 6, StaffName = "katrina", staff_category = "nurse", Email = "katrina@Movie.com", ContactNo = 998899, Education = "bsc nursing", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "Cancer", Fees = 7000, patientsattended = 10 },
            
            new Nurse() { StaffId = 7, StaffName = "kareena", staff_category = "nurse", Email = "kareena@Movie.com", ContactNo = 998899, Education = "anm", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "Cancer", Fees = 8000, patientsattended = 10 }
        
        };

        public void Add()
        {
            using (var writer = new StreamWriter(@"C:\Staff\nurse.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(nurse);
            }
        }

        public void Get()
        {
            Console.WriteLine("Enter StaffId");
            int id = Convert.ToInt32(Console.ReadLine());
            using (var reader = new StreamReader(@"C:\Staff\nurse.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var data = csv.GetRecords<Nurse>();
                foreach (var v in data)
                {
                    if (v.StaffId == id)
                    {
                        Console.WriteLine(v.StaffName);
                    }
                }
            }
        }
    }
}
