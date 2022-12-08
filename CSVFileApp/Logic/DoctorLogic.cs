using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSVFileApp.Models;
using CsvHelper;

namespace CSVFileApp.Logic
{
    public class DoctorLogic
    {
        public List<Doctor> doctor = new List<Doctor>()
        {
            new Doctor() { StaffId = 1, StaffName = "divyansh", staff_category = "doctor", Email = "divyansh@Movie.com", ContactNo = 998899, Education = "M.B.B.S", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "Cancer", Fees = 6456, MaxPatientsPerDay = 10 },
        
            new Doctor() { StaffId = 2, StaffName = "omkar", staff_category = "doctor", Email = "omkar@Movie.com", ContactNo = 997799, Education = "B.A.M.S", ShiftStartTime = 7, ShiftEndTime = 19, Specialization = "Heart", Fees = 6000, MaxPatientsPerDay = 8 },
        
           new Doctor() { StaffId = 3, StaffName = "rahul", staff_category = "doctor", Email = "rahul@Movie.com", ContactNo = 996699, Education = "B.A.M.S", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "Heart", Fees = 7000, MaxPatientsPerDay = 6 },
            new Doctor() { StaffId = 4, StaffName = "vivek", staff_category = "doctor", Email = "vivek@Movie.com", ContactNo = 995599, Education = "B.H.M.S", ShiftStartTime = 9, ShiftEndTime = 21, Specialization = "Cancer", Fees = 8000, MaxPatientsPerDay = 16 },
       
            new Doctor() { StaffId = 5, StaffName = "omkar", staff_category = "doctor", Email = "omkar@Movie.com", ContactNo = 994499, Education = "M.B.B.S", ShiftStartTime = 10, ShiftEndTime = 22, Specialization = "eye", Fees = 8000, MaxPatientsPerDay = 17 },
        
            new Doctor() { StaffId = 6, StaffName = "anurag", staff_category = "doctor", Email = "anurag@Movie.com", ContactNo = 993399, Education = "M.B.B.S", ShiftStartTime = 9, ShiftEndTime = 21, Specialization = "Cancer", Fees = 6556, MaxPatientsPerDay = 18 },
       
            new Doctor() { StaffId = 7, StaffName = "rohan", staff_category = "doctor", Email = "rohan@Movie.com", ContactNo = 992299, Education = "B.H.M.S", ShiftStartTime = 10, ShiftEndTime = 22, Specialization = "eye", Fees = 9000, MaxPatientsPerDay = 19 },
        
            new Doctor() { StaffId = 8, StaffName = "sachin", staff_category = "doctor", Email = "sachin@Movie.com", ContactNo = 991199, Education = "ssc", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "driving", Fees = 8000, MaxPatientsPerDay = 9 }
        

        };

        public void Add() 
        {
            using (var writer = new StreamWriter(@"C:\Staff\doctor.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(doctor);
            }
        }

        public void Get() 
        {
            Console.WriteLine("Enter StaffId");
            int id = Convert.ToInt32(Console.ReadLine());
            using (var reader = new StreamReader(@"C:\Staff\doctor.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var data = csv.GetRecords<Doctor>();
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
