using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApplication
{
    public class Data
    {
        public List<Doctor> doctors = new List<Doctor>();
        public void add() 
        {
            Doctor doc1 = new Doctor() { StaffId = 1, StaffName = "Divyansh", Email = "divyansh@Movie.com", contactno = 998899, Education = "M.B.B.S", ShiftStartTime = 8, ShiftEndTime = 20, DeptName = "Cancer", Staffcategory = "doctor",BasicPay = 10000, NetSalary = 0,MaxPatientsPerDay =10 };
            doctors.Add(doc1);
            Doctor doc2 = new Doctor() { StaffId = 2, StaffName = "omkar", Email = "omkar@Movie.com", contactno = 997799, Education = "B.A.M.S", ShiftStartTime = 7, ShiftEndTime = 19, DeptName = "Heart", Staffcategory = "doctor", BasicPay = 20000, NetSalary = 0, MaxPatientsPerDay = 12};
            doctors.Add(doc2);
            Doctor doc3 = new Doctor() { StaffId = 3, StaffName = "rahul", Email = "rahul@Movie.com", contactno = 996699, Education = "B.A.M.S", ShiftStartTime = 8, ShiftEndTime = 20, DeptName = "Heart", Staffcategory = "doctor", BasicPay = 30000, NetSalary = 0, MaxPatientsPerDay = 10 };
            doctors.Add(doc3);
            Doctor doc4 = new Doctor() { StaffId = 4, StaffName = "vivek", Email = "vivek@Movie.com", contactno = 995599, Education = "B.H.M.S", ShiftStartTime = 9, ShiftEndTime = 21, DeptName = "Cancer", Staffcategory = "doctor", BasicPay = 40000, NetSalary = 0, MaxPatientsPerDay = 15 };
            doctors.Add(doc4);
            Doctor doc5 = new Doctor() { StaffId = 5, StaffName = "omkar", Email = "omkar@Movie.com", contactno = 994499, Education = "M.B.B.S", ShiftStartTime = 10, ShiftEndTime = 22, DeptName = "eye", Staffcategory = "doctor", BasicPay = 50000, NetSalary = 0, MaxPatientsPerDay = 20 };
            doctors.Add(doc5);
            Doctor doc6 = new Doctor() { StaffId = 6, StaffName = "anurag", Email = "anurag@Movie.com", contactno = 993399, Education = "M.B.B.S", ShiftStartTime = 9, ShiftEndTime = 21, DeptName = "Cancer", Staffcategory = "doctor", BasicPay = 10000, NetSalary = 0, MaxPatientsPerDay = 30 };
            doctors.Add(doc6);
            Doctor doc7 = new Doctor() { StaffId = 7, StaffName = "rohan", Email = "rohan@Movie.com", contactno = 992299, Education = "B.H.M.S", ShiftStartTime = 10, ShiftEndTime = 22, DeptName = "eye", Staffcategory = "doctor", BasicPay = 10000, NetSalary = 0, MaxPatientsPerDay = 10 };
            doctors.Add(doc7);
            Doctor doc8 = new Doctor() { StaffId = 8, StaffName = "sachin", Email = "sachin@Movie.com", contactno = 991199, Education = "ssc", ShiftStartTime = 8, ShiftEndTime = 20, DeptName = "driving", Staffcategory = "doctor", BasicPay = 10000, NetSalary = 0, MaxPatientsPerDay = 50 };
            doctors.Add(doc8);
        }
    }
}
