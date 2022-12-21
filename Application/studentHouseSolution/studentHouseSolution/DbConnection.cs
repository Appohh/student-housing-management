using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentHouseSolution
{
    //All db connections go trough here
    public class DbConnection 
    {
        private readonly string connectionString;

        protected virtual string readCmd { get; }

        public DbConnection()
        {
            connectionString = "Server = db4free.net; Database = studenthousing; Uid = studenthousing; Pwd = studenthousing;";
        }

        protected MySqlConnection getConnection()
        {
            return new MySqlConnection(connectionString);
        }

        protected DataTable ReadTable()
        {
            DataTable result = new DataTable();
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    //Get task rows
                    command.CommandText = this.readCmd;
                    var data = command.ExecuteReader();
                    result.Load(data);
                }
            }

            return result;
        }
    }
}
