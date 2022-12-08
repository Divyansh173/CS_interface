using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryThread
{
    public class Employees
    {
        int _empno;
        int _deptno;
        string _empname;
        string _designation;
        int _salary;

        public int ID
        {
            get { return _empno; }
            set { _empno = value; }
        }
        public int Deptno
        {
            get { return _deptno; }
            set { _deptno = value; }
        }
        public string EmpName
        {
            get { return _empname; }
            set { _empname = value; }
        }

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public string Designation
        {
            get { return _designation; }
            set { _designation = value; }
        }

    }

    public class Department
    {
        int _deptno;
        string _deptname;



        public int Deptno
        {
            get { return _deptno; }
            set { _deptno = value; }
        }
        public string DeptName
        {
            get { return _deptname; }
            set { _deptname = value; }
        }

    }
}
