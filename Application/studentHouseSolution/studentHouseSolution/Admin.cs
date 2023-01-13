using Org.BouncyCastle.Asn1.Crmf;
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
    public partial class Admin : Form
    {
        Person loggedInUser;
        taskDatabase tasks = new taskDatabase();
        personDatabase persons = new personDatabase();
        bool toggleRegister = true;
        bool toggleCreateTask = true;

        public Admin(Person userLoggedIn)
        {
            InitializeComponent();

            tasks.getData();
            persons.getData();
            loggedInUser = userLoggedIn;

            refreshComboBox();
        }

        public void refreshComboBox()
        {
            
            cbPerson.DataSource = null;
            cbTasks.DataSource = null;
            cbPersonPerson.DataSource = null;

            cbPerson.DataSource = persons.getPersons();
            cbPerson.DisplayMember = "firstName";
            cbPerson.ValueMember = "id";
            cbTasks.DataSource = tasks.getTasks();
            cbTasks.DisplayMember = "name";
            cbTasks.ValueMember = "id";
            cbPersonPerson.DataSource = persons.getPersons();
            cbPersonPerson.DisplayMember = "firstName";
            cbPersonPerson.ValueMember = "id";

        }

        //give collection of controls and toggle the visibility with the given value, reverse is the control that gets text
        public void toggleVisibility(bool visible, List<Control> elements, Control? reverse = null, string? controltext = null)
        {
            foreach (var element in elements)
            {
                element.Visible = visible;
            }

            if (reverse != null && controltext != null)
            {
                reverse.Text = controltext;
            }

        }

        private void btnShowRegister_Click(object sender, EventArgs e)
        {
            var controls = new List<Control> { txtFirstName, txtLastName, txtEmail, txtPassword, cbAdmin, btnRegister, cbPersonPerson, btnDeletePerson};

            //show and hide right fields
            if (toggleRegister)
            {
                toggleVisibility(true, controls, btnShowRegister, "Cancel person tools");
                toggleRegister = false;
            }
            else if (!toggleRegister)
            {
                toggleVisibility(false, controls, btnShowRegister, "Person tools");
                toggleRegister = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var controls = new List<Control> { txtFirstName, txtLastName, txtEmail, txtPassword, cbAdmin, btnRegister, btnDeletePerson, cbPersonPerson };

            int role = 0;
            if (string.IsNullOrEmpty(txtFirstName.Text))  { MessageBox.Show("Please fill in your firstname!"); return; }
            if (string.IsNullOrEmpty(txtLastName.Text)) { MessageBox.Show("Please fill in your lastname!"); return; }
            if (string.IsNullOrEmpty(txtEmail.Text)) { MessageBox.Show("Please fill in your email!"); return; }
            if (string.IsNullOrEmpty(txtPassword.Text)) { MessageBox.Show("Please fill in your password!"); return; }
            if (cbAdmin.Checked) { role = 1; }

            //if succesful
            if (persons.registerNewPerson(txtFirstName.Text, txtLastName.Text, txtPassword.Text, txtEmail.Text, role) > 0)
            {
                MessageBox.Show("User " + txtFirstName.Text + " " + txtLastName.Text + " registered succesfuly!");
                txtFirstName.Text = "";txtLastName.Text = "";txtEmail.Text = "";txtPassword.Text = "";

                //show and hide right fields
                toggleVisibility(false, controls, btnShowRegister, "Person tools");
                persons.getData();
                refreshComboBox();
            } else //if unsuccesful
            {
                MessageBox.Show("Something went wrong while communicating trough database.");
            }

        }

        private void btnShowTaskCreate_Click(object sender, EventArgs e)
        {
            var controls = new List<Control> { btnCreateTask, txtName, txtDescription, lblCycle, lblDueDate, lblPerson, lblStartDate, dtpStartDate, dtpDueDate, nudCycle, cbPerson, cbTasks, btnDeleteTask};

            //show and hide right fields
            if (toggleCreateTask)
            {
                toggleVisibility(true, controls, btnShowTaskCreate, "Cancel task tools");
                toggleCreateTask = false;
            }
            else if (!toggleCreateTask)
            {
                toggleVisibility(false, controls, btnShowTaskCreate, "Task tools");
                toggleCreateTask = true;
            }
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            var controls = new List<Control> { btnCreateTask, txtName, txtDescription, lblCycle, lblDueDate, lblPerson, lblStartDate, dtpStartDate, dtpDueDate, nudCycle, cbPerson, btnDeleteTask, cbTasks };

            if (string.IsNullOrEmpty(txtName.Text)) { MessageBox.Show("Please fill in Name!"); return; }
            if (string.IsNullOrEmpty(txtDescription.Text)) { MessageBox.Show("Please fill in Description!"); return; }
            if (dtpDueDate.Value < DateTime.Now) { MessageBox.Show("Duedate cannot be in the past or today!"); return; }
            if (dtpDueDate.Value < dtpStartDate.Value) { MessageBox.Show("Duedate cannot be before startdate!"); return; }
            if (cbPerson.SelectedValue == null) { MessageBox.Show("Choose a person of the list!"); return; }
            if (nudCycle == null) { MessageBox.Show("Enter number of days to cycle!"); return; }

            //format dates for db
            DateTime startdateSource = DateTime.Parse(dtpStartDate.Value.ToString());
            string startdateFormat = startdateSource.ToString("yyyy-MM-dd");
            DateTime duedateSource = DateTime.Parse(dtpDueDate.Value.ToString());
            string duedateFormat = duedateSource.ToString("yyyy-MM-dd");

            //if succesful
            if (tasks.createNewTask(txtName.Text, txtDescription.Text, startdateFormat, duedateFormat, nudCycle.Value.ToString(), cbPerson.SelectedValue.ToString()) > 0)
            {
                MessageBox.Show("Task " + txtName.Text + " created succesfuly between " + startdateFormat + " and " + duedateFormat + "!");
                txtName.Text = ""; txtDescription.Text = ""; nudCycle.Value = 0;

                //show and hide right fields
                toggleVisibility(false, controls, btnShowTaskCreate, "Task tools");
                tasks.getData();
                refreshComboBox();
            }
            else //if unsuccesful
            {
                MessageBox.Show("Something went wrong while communicating trough database.");
            }
           
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            var controls = new List<Control> { btnCreateTask, txtName, txtDescription, lblCycle, lblDueDate, lblPerson, lblStartDate, dtpStartDate, dtpDueDate, nudCycle, cbPerson, btnDeleteTask, cbTasks };

            if (cbTasks.SelectedValue == null) { MessageBox.Show("Choose a task to delete!"); return; }
            if (tasks.deleteTask(cbTasks.SelectedValue.ToString()) > 0)
            {
                MessageBox.Show("Task deleted succesfully!");
                toggleVisibility(false, controls, btnShowTaskCreate, "Task tools");
                tasks.getData();
                refreshComboBox();
            }
            else
            {
                MessageBox.Show("Something went wrong while communicating trough database.");
            }

        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            var controls = new List<Control> { txtFirstName, txtLastName, txtEmail, txtPassword, cbAdmin, btnRegister, btnDeletePerson, cbPersonPerson };

            if (cbPersonPerson.SelectedValue == null) { MessageBox.Show("Choose a person to delete!"); return; }
<<<<<<< HEAD
            foreach(Task task in tasks.getTasks())
=======
            foreach (Task task in tasks.getTasks())
>>>>>>> a77d8bfc174fac8031dd7b3d10de4b3eb84411dd
            {
                if(task.personId == Convert.ToInt32(cbPersonPerson.SelectedValue))
                {
                    if (task.status == 0)
                    {
                        MessageBox.Show("Person currently has tasks!");
<<<<<<< HEAD
                    }
                }
            }

=======
                        return;
                    }
                }
            }
>>>>>>> a77d8bfc174fac8031dd7b3d10de4b3eb84411dd
            if (persons.deletePerson(cbPersonPerson.SelectedValue.ToString()) > 0)
            {
                MessageBox.Show("Person deleted succesfully!");
                toggleVisibility(false, controls, btnShowRegister, "Person tools");
                persons.getData();
                refreshComboBox();
            }
            else
            {
                MessageBox.Show("Something went wrong while communicating trough database.");
            }
        }
    }
}
