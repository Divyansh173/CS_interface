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
    public class TechnicianLogic
    {
        public List<Technician> technician = new List<Technician>()
        {
            new Technician() { StaffId = 1, StaffName = "mihir", staff_category = "technician", Email = "mihir@Movie.com", ContactNo = 96799, Education = "hsc", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "driving", Expertise = "ambulance" },
            new Technician() { StaffId = 2, StaffName = "subhankar", staff_category = "technician", Email = "subhankar@Movie.com", ContactNo = 12354, Education = "hsc", ShiftStartTime = 10, ShiftEndTime = 20, Specialization = "driving", Expertise = "ambulance" },
        
            new Technician() { StaffId = 3, StaffName = "pavan", staff_category = "technician", Email = "pavan@Movie.com", ContactNo = 672347, Education = "ssc", ShiftStartTime = 7, ShiftEndTime = 20, Specialization = "driving", Expertise = "ambulance" },
      
            new Technician() { StaffId = 4, StaffName = "ram", staff_category = "technician", Email = "ram@Movie.com", ContactNo = 34437, Education = "ssc", ShiftStartTime = 18, ShiftEndTime = 20, Specialization = "driving", Expertise = "ambulance" },
        
            new Technician() { StaffId = 5, StaffName = "laxman", staff_category = "technician", Email = "laxamn@Movie.com", ContactNo = 28934, Education = "hsc", ShiftStartTime = 20, ShiftEndTime = 20, Specialization = "driving", Expertise = "ambulance" },
        
            new Technician() { StaffId = 6, StaffName = "manav", staff_category = "technician", Email = "manav@Movie.com", ContactNo = 28943, Education = "ssc", ShiftStartTime = 9, ShiftEndTime = 20, Specialization = "driving", Expertise = "ambulance" },
        
            new Technician() { StaffId = 7, StaffName = "hemant", staff_category = "technician", Email = "hemant@Movie.com", ContactNo = 97329, Education = "hsc", ShiftStartTime = 7, ShiftEndTime = 20, Specialization = "driving", Expertise = "ambulance" }
        
        };

        public void Add()
        {
            using (var writer = new StreamWriter(@"C:\Staff\technician.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(technician);
            }
        }

        public void Get()
        {
            Console.WriteLine("Enter StaffId");
            int id = Convert.ToInt32(Console.ReadLine());
            using (var reader = new StreamReader(@"C:\Staff\technician.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var data = csv.GetRecords<Technician>();
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
