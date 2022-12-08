// See https://aka.ms/new-console-template for more information
using ThreadFirst;
using System.Diagnostics;

Data data = new Data();
data.add();
Logic logic = new Logic();
FileOp fileop = new FileOp(logic.Update);
fileop += logic.WriteFile;
fileop += logic.SalarySlip;
var parallelTimer1 = Stopwatch.StartNew();
for (int i = 0; i < data.doctors.Count; i++)
{
    Thread file = new Thread(() =>  fileop(data.doctors, i));
    file.Start();
    file.Join();
}
Console.WriteLine($"Parallel Timing {parallelTimer1.Elapsed.TotalMilliseconds}");

var parallelTimer = Stopwatch.StartNew();
Parallel.Invoke(() =>
{
    for (int i = 0; i < data.doctors.Count; i++) 
    {
        fileop(data.doctors, i);
    }
}
);
Parallel.Invoke()
Console.WriteLine($"Parallel Timing {parallelTimer.Elapsed.TotalMilliseconds}");

//Thread update = new Thread(() => logic.Update(data.doctors));
//update.Start();
//update.Join();
//Thread write = new Thread(() => logic.WriteFile(data.doctors));
//write.Start();
//write.Join();
//Thread salaryslip = new Thread(() => logic.SalarySlip(data.doctors));
//salaryslip.Start();
//salaryslip.Join();


