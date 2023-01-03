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

        //All task objects will be stored in this list:
        private List<Task> Tasks = new List<Task>();

        //override command to get rows from database table
        protected override string readCmd
        {
            get
            {
                return "select * from Task";
            }
        }

        public void getData()
        {
            //clear objects so there will be no duplicates:
            this.Tasks.Clear();

            //get table from database
            DataTable table = ReadTable();

            //itterate trough all rows of given database -> datatable
            foreach (DataRow dr in table.Rows)
            {
                Tasks.Add(new Task(Convert.ToInt32(dr["Id"]), dr["Name"].ToString(), dr["Description"].ToString(),
                    dr["DueDate"].ToString(), dr["StartDate"].ToString(), Convert.ToInt32(dr["Cycle"]),
                    Convert.ToInt32(dr["PersonId"]), Convert.ToInt32(dr["Status"]), dr["Timestamp"].ToString()));
            }
        }

        public int createNewTask(string name, string description, string startdate, string duedate, string cycle, string personid)
        {
            string query = $"INSERT INTO `Task` (`Name`, `Description`, `StartDate`, `DueDate`, `Cycle`, `PersonId`) VALUES ('{name}', '{description}', '{startdate}', '{duedate}', '{cycle}', '{personid}');";
            return executeQuery(query);
        }

        public void checkTask(string id)
        {
            string query = "UPDATE Task SET Status = 1 where Id = " + id;
            executeQuery(query);
        }

        //return all task-row objects
        public List<Task> getTasks()
        {
            return Tasks;
        }
   
    }
}
