using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;

namespace CS_AdoDisconnected
{
    public class DataAccess
    {
        SqlConnection Conn;
        SqlDataAdapter AdDepartment;
        DataSet Ds;
        DataRow DrFind;

        public DataAccess() 
        {
            Conn = new SqlConnection("Data Source =.; Initial Catalog = eShoppingCodi; Integrated Security = SSPI");
            Ds = new DataSet();
            LoadData();
        }

        private void LoadData() 
        {
            AdDepartment = new SqlDataAdapter("Select * from Department", Conn);
            
            // MAke sure that metadata of the table is put in dataset
            AdDepartment.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            
            // Fill data into dataset
            AdDepartment.Fill(Ds, "Department");
            AdDepartment = new SqlDataAdapter("select * from employee",Conn);
            AdDepartment.Fill(Ds, "Employee");

            // Print data from dataset
            Console.WriteLine(Ds.GetXml());
        }

        public void AddNewDepartment() 
        {
            // Crate a space in Department table in datset for adding new row
            DataRow dataRow = Ds.Tables["Department"].NewRow();
            dataRow["DeptNo"] = 500;
            dataRow["DeptName"] = "Accounts";
            dataRow["Location"] = "Mumbai";
            dataRow["Capacity"] = 7900;


            // Add new row to dataset
            Ds.Tables["Department"].Rows.Add(dataRow);

            //  Console.WriteLine(Ds.GetXml());

            SqlCommandBuilder builder = new SqlCommandBuilder(AdDepartment);
            AdDepartment.Update(Ds, "Department");
        }

        public void FindRecord( int Dno) 
        {
            DrFind = Ds.Tables["Department"].Rows.Find(Dno);

            //The row is already Associated with the tbale

            Console.WriteLine($"{DrFind["DeptName"]}  {DrFind["Location"]}");
        }

        public void Update(int Dno) 
        {
            DrFind = Ds.Tables["Department"].Rows.Find(Dno);


            DrFind["DeptName"] = "New Dept";
            DrFind["Location"] = "New York";
            DrFind["Capacity"] = "1234";

            SqlCommandBuilder builder = new SqlCommandBuilder(AdDepartment);
            AdDepartment.Update(Ds, "Department");
        }

        public void Delete(int Dno) 
        {
            DrFind = Ds.Tables["Department"].Rows.Find(Dno);

            DrFind.Delete();

            SqlCommandBuilder builder = new SqlCommandBuilder(AdDepartment);
            AdDepartment.Update(Ds, "Department");
        }

        public void datarelation() 
        {
            DataRelation dr = Ds.Relations.Add("All", Ds.Tables["Department"].Columns["DeptNo"], Ds.Tables["Employee"].Columns["DeptNo"]);

            foreach (DataRow dr1 in Ds.Tables["Department"].Rows) 
            {
                Console.WriteLine(dr1["DeptNo"]);
                DataRow[] dataRows = dr1.GetChildRows(dr);
                foreach (DataRow dr2 in dataRows) 
                { 
                    Console.WriteLine(dr2["EmpName"]);
                }
            }
        }
    }
}
