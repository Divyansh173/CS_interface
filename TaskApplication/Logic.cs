using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace TaskApplication
{

    public class AsyncLogic
    {
        public async Task UpdateAsync(List<Doctor> list1, int id)
        {
            //await Task.Run(() =>
            //{
                list1[id].Tax = (12 * (list1[id].BasicPay + list1[id].MaxPatientsPerDay * 1000)) / 100;
                list1[id].NetSalary = list1[id].BasicPay + list1[id].MaxPatientsPerDay * 1000 - list1[id].Tax;
            //}
            //);

        }

        public async void WriteAllDataAsync(List<Doctor> list1, int id)
        {
            //Task.Run(() =>
            //{
            using (StreamWriter sw = new StreamWriter(@"C:\all.txt", true))
                {
                    var data = JsonSerializer.Serialize<Doctor>(list1[id]);
                    await sw.WriteLineAsync(data);
                }
            //}
            //);
        }

        public async void SalarySlipAsync(List<Doctor> list1, int id)
        {
            //await Task.Run(() =>
            //{
                using (StreamWriter sw = new StreamWriter($@"C:\SalarySlip\{list1[id].StaffId}"))
                {
                    await sw.WriteAsync($"Name : {list1[id].StaffName} \nBasicSalary : {list1[id].BasicPay} \nTax : {list1[id].Tax} \nNetSalary : {list1[id].NetSalary}");
                }
            //}
            //);


        }
    }
}
