using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentHouseSolution
{
    public class personDatabase : DbConnection
    {

        //All task objects will be stored in this list:
        private List<Person> Persons = new List<Person>();

        //override command to get rows from database table
        protected override string readCmd
        {
            get
            {
                return "select * from Person";
            }
        }

        public void getData()
        {
            //clear objects so there will be no duplicates:
            this.Persons.Clear();

            //get table from database
            DataTable table = ReadTable();

            //itterate trough all rows of given database -> datatable
            foreach (DataRow dr in table.Rows)
            {
                Persons.Add(new Person(Convert.ToInt32(dr["Id"]), dr["firstName"].ToString(), dr["lastName"].ToString(),
                    dr["PasswordHash"].ToString(), dr["Email"].ToString(), Convert.ToInt32(dr["role"]), dr["TimeStamp"].ToString()));
            }
        }

        public int registerNewPerson(string firstname, string lastname, string password, string email, int role)
        {
            string query = $"INSERT INTO `Person` (`firstName`, `lastName`, `PasswordHash`, `Email`, `role`) VALUES ('{firstname}', '{lastname}', '{password}', '{email}', '{role}');";
            return executeQuery(query);
        }

       public int deletePerson(string id)
        {
            string query = "DELETE FROM Person where Id = " + id;
            return executeQuery(query);
        }

        //return all person-row objects
        public List<Person> getPersons()
        {
            return Persons;
        }
    }
}
