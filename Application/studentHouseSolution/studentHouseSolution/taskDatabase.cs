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
    public class taskDatabase : DbConnection
    {
        public string? cmd;
        private DataTable DtTasks = new DataTable();
        private List<Task> Tasks = new List<Task>();
        protected override string readCmd
        {
            get
            {
                return "select * from Task";
            }
        }

        public void ReadAll()
        {

            

           

        }

        List<Task> getData()
        {
            DataTable table = this.ReadTable();
            List<Task> result = new List<Task>();
            foreach(DataRow dr in table)
            {
                result.Add(new Task(dr[0], ...));
            }

            return result;
        }

        public DataTable getTasks()
        {
            return this.DtTasks;
        }

    }
}
