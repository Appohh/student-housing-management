using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentHouseSolution
{
    public partial class SeeComplaintsForm : Form
    {

        List<Person> persons;
        List<Complaint> complaints;

        Person? getPersonById(int id)
        {
            foreach(Person person in persons)
            {
                if(person.id == id) return person;
            }
            return null;
        }
        
        public void addComplaintLabel(string title, string description, string person, string timestamp)
        {

            //add new label
            Label lbl = new Label();
            lbl.Text = title + "\r\n\r\n" + description + "\r\n\r\nDate : " + timestamp.Substring(0,10) + "\r\n\r\nPerson: " + person;
            lbl.BackColor = Color.RoyalBlue;
            lbl.Font = new Font("ROG Fonts", 12);
            lbl.ForeColor = Color.White;
            lbl.AutoSize = false;
            lbl.Size = new Size(614, 340);
            lbl.Margin = new Padding(10);

            //add whole label to flowlayoutpanel
            flowLayoutPanel1.Controls.Add(lbl);
        }


        public SeeComplaintsForm()
        {
            InitializeComponent();
            personDatabase personsDb = new personDatabase();
            complaintsDatabase complaintsDb = new complaintsDatabase();

            personsDb.getData();
            complaintsDb.getData();

            persons = personsDb.getPersons();
            complaints = complaintsDb.getComplaints();

            
            foreach(Complaint complaint in complaints)
            {
                Person? author = getPersonById(complaint.PersonId);
                string authorName;
                if (author == null) authorName = "[Deleted]";
                else if (complaint.Anonymous) authorName = "Anonymous";
                else authorName = author.firstName + " " + author.lastName;

                addComplaintLabel(complaint.Title, complaint.Description, authorName, complaint.Timestamp);
            }
        }
    }
}
