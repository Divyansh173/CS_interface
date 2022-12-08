using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;
using CS_Dapper.Constants;
using System.Data;

namespace CS_Dapper.DbConnect
{
    internal class EShopingCodiContext
    {
        /// <summary>
        /// The class that will be used to Return an INstance of SQLConnection
        /// class so that, the DB Connection will be stablished
        /// </summary>
        
            private readonly string connStr;
            public EShopingCodiContext()
            {
                connStr = StaticConstants.ConnectionString;
            }
            // Retun an Instance of SqlCOnnection Class
            public IDbConnection CreateConnection()
                => new SqlConnection(connStr);
        
    }
}
