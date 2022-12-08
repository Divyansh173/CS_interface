using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_SimleDataAccess.Models;
using System.Data.SqlClient;


namespace CS_SimleDataAccess.DataAccess
{
    public class ProductDbAccess : IDbAccess<Product, int>
    {
        SqlConnection Conn;
        SqlCommand Cmd;

        public ProductDbAccess()
        {
            Conn = new SqlConnection("Data Source = .; Initial Catalog = eShoppingcodi; Integrated Security = SSPI");
        }
        Product IDbAccess<Product, int>.Create(Product entity)
        {
            throw new NotImplementedException();
        }

        Product IDbAccess<Product, int>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IDbAccess<Product, int>.GetAll()
        {
            List<Product> records = new List<Product>();
            try
            {
                // 1. Open the Connection
                Conn.Open();
                // 2. Creating Command
                Cmd = new SqlCommand();
                // Set the COnnection object to COmmand
                Cmd.Connection = Conn;
                // 2.a. Setting the Command Properties for TExt 
                Cmd.CommandType = System.Data.CommandType.Text;
                Cmd.CommandText = "Select * from product";
                // 3. Execute
                SqlDataReader Reader = Cmd.ExecuteReader();
                // 3.a. STart REading Records
                while (Reader.Read())
                {
                    records.Add(new Product()
                    {
                        ProductUniqueId = Convert.ToInt32(Reader["ProductUniqueID"]),
                        ProductId = Reader["ProductID"].ToString(),
                        ProductName = Reader["ProductID"].ToString(),
                        Description = Reader["Description"].ToString(),
                        Price = Convert.ToInt32(Reader["Price"])
                    }) ;
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
            return records;
        }

        Product IDbAccess<Product, int>.Get(int id)
        {
            throw new NotImplementedException();
        }

        Product IDbAccess<Product, int>.Update(int id, Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
