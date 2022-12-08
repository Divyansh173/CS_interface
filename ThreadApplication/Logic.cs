using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace ThreadFirst
{


    public delegate void FileOp(List<Doctor> doctors, int id);
    public class Logic
    {
        public void Update(List<Doctor> list1, int id) 
        {
                list1[id].Tax = (12 * (list1[id].BasicPay + list1[id].MaxPatientsPerDay * 1000)) / 100;
                list1[id].NetSalary = list1[id].BasicPay + list1[id].MaxPatientsPerDay * 1000 - list1[id].Tax;
               
        }

        public void WriteFile(List<Doctor> list1, int id) 
        {
                using (StreamWriter sw = new StreamWriter(@"C:\all.txt", true))
                {
                    var data = JsonSerializer.Serialize<Doctor>(list1[id]);
                    sw.WriteLine(data);
                }
        }

        public void SalarySlip(List<Doctor> list1, int id) 
        {
                using (StreamWriter sw = new StreamWriter($@"C:\SalarySlip\{list1[id].StaffId}"))
                {
                    sw.Write($"Name : {list1[id].StaffName} \nBasicSalary : {list1[id].BasicPay} \nTax : {list1[id].Tax} \nNetSalary : {list1[id].NetSalary}");
                }
           
            
        }
    }
}
