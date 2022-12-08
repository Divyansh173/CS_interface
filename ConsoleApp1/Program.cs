// See https://aka.ms/new-console-template for more information
using ConsoleApp1.DataAccess;
using ConsoleApp1.Models;
Console.WriteLine("Hello, World!");
Department department = new Department() { DeptNo= 10, DeptName = "Finance", Capacity= 1000, Location="pune"};
DepartentDataAccess DepartentDataAccess = new DepartentDataAccess();
DepartentDataAccess.UpdateAsync(10, department);

