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
    //all db connections go trough here
    public class DbConnection
    {
        private readonly string connectionString;

        //this will be the "current" command string for parent classes:
        protected virtual string readCmd { get; }

        public DbConnection()
        {
            //?? encrypt? ??
            connectionString = "Server = db4free.net; Database = studenthousing; Uid = studenthousing; Pwd = studenthousing;";
        }

        //function to get new db connection
        private MySqlConnection getConnection()
        {
            return new MySqlConnection(connectionString);
        }

        //function to get rows from db as datatable:
        protected DataTable ReadTable()
        {
            DataTable result = new DataTable();
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    //get command
                    command.CommandText = this.readCmd;
                    //get data
                    var data = command.ExecuteReader();
                    //fill datatable with querried data
                    result.Load(data);
                }
            }

            return result;
        }

        //executes sql command
        protected int executeQuery(string query)
        {
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = query;
                    return command.ExecuteNonQuery();

                }
            }
        }


    }
}
