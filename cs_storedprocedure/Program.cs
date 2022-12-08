// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;

SqlConnection conn;
SqlCommand cmd;

try
{
    conn = new SqlConnection("Data Source =.; Initial Catalog = eShoppingCodi; Integrated Security=SSPI");
    conn.Open();
    cmd = conn.CreateCommand();
    cmd.CommandType = System.Data.CommandType.StoredProcedure;
    cmd.CommandText = "sp_InsertEmployee";


    SqlParameter pEmpNo = new SqlParameter();
    pEmpNo.ParameterName = "@Empno";
    pEmpNo.DbType = System.Data.DbType.Int32;
    pEmpNo.Direction = System.Data.ParameterDirection.Input; // DEfault is Input
    pEmpNo.Value = 142;
    cmd.Parameters.Add(pEmpNo);

    SqlParameter pEmpName = new SqlParameter();
    pEmpName.ParameterName = "@EmpName";
    pEmpName.DbType = System.Data.DbType.String;
    pEmpName.Direction = System.Data.ParameterDirection.Input; // DEfault is Input
    pEmpName.Value = "Omkar";
    cmd.Parameters.Add(pEmpName);

    SqlParameter pDesignation = new SqlParameter();
    pDesignation.ParameterName = "@Designation";
    pDesignation.DbType = System.Data.DbType.String;
    pDesignation.Direction = System.Data.ParameterDirection.Input; // DEfault is Input
    pDesignation.Value = "Assocte";
    cmd.Parameters.Add(pDesignation);

    SqlParameter pSalary = new SqlParameter();
    pSalary.ParameterName = "@Salary";
    pSalary.DbType = System.Data.DbType.Int32;
    pSalary.Direction = System.Data.ParameterDirection.Input; // DEfault is Input
    pSalary.Value = 100000;
    cmd.Parameters.Add(pSalary);

    SqlParameter pDeptNo = new SqlParameter();
    pDeptNo.ParameterName = "@DeptNo";
    pDeptNo.DbType = System.Data.DbType.Int32;
    pDeptNo.Direction = System.Data.ParameterDirection.Input; // DEfault is Input
    pDeptNo.Value = 90;
    cmd.Parameters.Add(pDeptNo);

    int result = cmd.ExecuteNonQuery();
    if (result > 0)
        Console.WriteLine("Record Added");
    Console.WriteLine("Failed");

}
catch (Exception ex )
{

    Console.WriteLine(ex.Message); ;
}
