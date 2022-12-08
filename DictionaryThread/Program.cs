// See https://aka.ms/new-console-template for more information
using DictionaryThread;
List<Employees> lstEmployees = new List<Employees> {
        new Employees{ID = 1 ,Deptno = 1, EmpName = "Mahesh", Salary= 5000, Designation = "developer"},
        new Employees{ID = 2 ,Deptno = 2, EmpName = "Divynahs", Salary= 60000,Designation = "developer"},
        new Employees{ID = 3 ,Deptno = 1, EmpName = "Rahul", Salary= 83000,Designation = "developer"},
        new Employees{ID = 4 ,Deptno = 3, EmpName = "Omkar", Salary= 63000,Designation = "developer"},
        new Employees{ID = 5 ,Deptno = 1, EmpName = "Mayank", Salary= 30000,Designation = "developer"},
        new Employees{ID = 6 ,Deptno = 4, EmpName = "harsh", Salary= 83000,Designation = "developer"},
        new Employees{ID = 7 ,Deptno = 1, EmpName = "Ritesh", Salary= 573000,Designation = "developer"},
        new Employees{ID = 8 ,Deptno = 3, EmpName = "roshan"  , Salary= 79000,Designation = "developer"},
        new Employees{ID = 9 ,Deptno = 1, EmpName = "Himanshu" , Salary= 45000,Designation = "developer" },
        new Employees{ID = 10 ,Deptno = 1, EmpName = "divynahsu" , Salary= 50000,Designation = "developer"},
        new Employees{ID = 11 ,Deptno = 2, EmpName = "suraj", Salary= 20000,Designation = "developer"},
        new Employees{ID = 12 ,Deptno = 1, EmpName = "dheeraj" , Salary= 50000,Designation = "developer" },
        new Employees{ID = 13 ,Deptno = 3, EmpName = "viraj", Salary= 20000,Designation = "developer"},
        new Employees{ID = 14 ,Deptno = 5, EmpName = "lokesh", Salary= 33000 ,Designation = "developer"},
        new Employees{ID = 15 ,Deptno = 4, EmpName = "Mukesh" , Salary= 43000,Designation = "developer" },
        new Employees{ID = 16 ,Deptno = 4, EmpName = "vivek" , Salary= 43000,Designation = "developer" },
        new Employees{ID = 17 ,Deptno = 3, EmpName = "anyrag" , Salary= 43000,Designation = "developer" },
        new Employees{ID = 18 ,Deptno = 2, EmpName = "anurag" , Salary= 42000,Designation = "developer" },
        new Employees{ID = 19 ,Deptno = 1, EmpName = "divyanshu" , Salary= 43000,Designation = "developer" },
        new Employees{ID = 20 ,Deptno = 5, EmpName = "ram" , Salary= 43000,Designation = "developer" },
        new Employees{ID = 21 ,Deptno = 6, EmpName = "shyam" , Salary= 50000,Designation = "developer" },
        new Employees{ID = 22 ,Deptno = 6, EmpName = "deepak" , Salary= 43000,Designation = "developer" },
        new Employees{ID = 23 ,Deptno = 6, EmpName = "billgates" , Salary= 50000,Designation = "developer" },
        new Employees{ID = 24 ,Deptno = 1, EmpName = "stevejobs" , Salary= 43000,Designation = "developer" },
        new Employees{ID = 25 ,Deptno = 3, EmpName = "jackma" , Salary= 67000,Designation = "developer" },
        new Employees{ID = 26 ,Deptno = 5, EmpName = "prince" , Salary= 43000,Designation = "developer" },
        new Employees{ID = 27 ,Deptno = 5, EmpName = "nitin" , Salary= 45000,Designation = "developer" },
        new Employees{ID = 28 ,Deptno = 2, EmpName = "Anikhil" , Salary= 53000,Designation = "developer" },
        new Employees{ID = 29 ,Deptno = 3, EmpName = "Adesh" , Salary= 43000,Designation = "developer" },
        new Employees{ID = 30 ,Deptno = 2, EmpName = "Asonu" , Salary= 00830,Designation = "developer" }
};
List<Department> lstdepartment = new List<Department> {
        new Department{ Deptno = 1,DeptName = "technician"},
        new Department{ Deptno = 2,DeptName = "It"},
        new Department{ Deptno = 3,DeptName = "Developer"},
        new Department{ Deptno = 4,DeptName = "cleaningStaff"},
        new Department{ Deptno = 5,DeptName = "manager"},
        new Department{ Deptno = 6,DeptName = "associate"},
};


Console.WriteLine("Enter DepartName");
string DeptName1 = Console.ReadLine();

var bgThread = new Thread((DeptName) => 
{
        bool flag = false;
        var data = from emp in lstEmployees
                   join department in lstdepartment on emp.Deptno equals department.Deptno
                   group emp by department.DeptName into newTable
                   select new
                   {
                       deptName = newTable.Key,
                       val = newTable
                   };
        foreach (var v in data) 
        {
            if (v.deptName == DeptName1) 
            {
                flag = true;
            Console.WriteLine($"ID  EmpName  Designation  Salary");
            foreach (var f in v.val) 
                {
                    Console.WriteLine($"{f.ID}  {f.EmpName}  {f.Designation}  {f.Salary} ");  
                }
                break;
            }
        }
        if (!flag) 
        {
            Console.WriteLine("Department is not present");
           
        } 
}

);
bgThread.IsBackground = true;
bgThread.Start(DeptName1);

Thread.Sleep(10000);

//Console.ReadLine();

