using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentHouseSolution
{
    public class Task : DbConnection
    {
        public string? cmd;
        private DataTable DtTasks = new DataTable();


        public void Read()
        {

            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    //Get task rows
                    command.CommandText = "select * from Task";
                    var data = command.ExecuteReader();
                    this.DtTasks.Load(data);
                }
            }

           

        }

        public DataTable getTasks()
        {
            return this.DtTasks;
        }

    }
}
