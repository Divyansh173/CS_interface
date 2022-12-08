// See https://aka.ms/new-console-template for more information
using TaskApplication;
using System.Diagnostics;
Data data = new Data();
data.add();
AsyncLogic logic = new AsyncLogic();
var startTime = Stopwatch.StartNew();
for (int i = 0; i < data.doctors.Count; i++) 
{
    await logic.UpdateAsync(data.doctors, i);
    logic.WriteAllDataAsync(data.doctors,i);
    logic.SalarySlipAsync(data.doctors,i);  
   // await task3;
}
var endTime = startTime.Elapsed.TotalMilliseconds;
Console.WriteLine(endTime);