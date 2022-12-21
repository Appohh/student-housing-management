using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentHouseSolution
{
    //All db connections go trough here
    public class DbConnection 
    {
        private readonly string connectionString;

        public DbConnection()
        {
            connectionString = "Server = db4free.net; Database = studenthousing; Uid = studenthousing; Pwd = studenthousing;";
        }

        protected MySqlConnection getConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
