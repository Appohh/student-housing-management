using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentHouseSolution
{
    class complaintsDatabase : DbConnection
    {
        protected override string readCmd
        {
            get
            {
                return "SELECT * FROM Complaint";
            }
        }

        private List<Complaint> complaints = new List<Complaint>();

        public void AddComplaint(int id, string title, string description, bool anonymous)
        {
            string escapedTitle = title.Replace("'", "''");
            string escapedDesc = description.Replace("'", "''");
            int intAnonymous = anonymous ? 1 : 0;
            executeQuery($"INSERT INTO Complaint (PersonId, Title, Description, Anonymous) VALUES ('{id}', '{escapedTitle}', '{escapedDesc}', {anonymous})");
        }
        public void getData()
        {
            //clear objects so there will be no duplicates:
            this.complaints.Clear();

            //get table from database
            DataTable table = ReadTable();

            //itterate trough all rows of given database -> datatable
            foreach (DataRow dr in table.Rows)
            {
                complaints.Add(new Complaint(Convert.ToInt32(dr["Id"]), (string)dr["Title"], (string)dr["Description"],
                Convert.ToInt32(dr["PersonId"]), Convert.ToBoolean(Convert.ToInt32(dr["Anonymous"])), dr["Timestamp"].ToString()));
            }
        }

        public List<Complaint> getComplaints()
        {
            return complaints;
        }

    }
}
