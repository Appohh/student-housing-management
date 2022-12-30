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
            cbPerson.DataSource = persons.getPersons();
            cbPerson.DisplayMember = "firstName";
            cbPerson.ValueMember = "id";
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
            var controls = new List<Control> { txtFirstName, txtLastName, txtEmail, txtPassword, cbAdmin, btnRegister};

            //show and hide right fields
            if (toggleRegister)
            {
                toggleVisibility(true, controls, btnShowRegister, "Cancel registering");
                toggleRegister = false;
            }
            else if (!toggleRegister)
            {
                toggleVisibility(false, controls, btnShowRegister, "Register new user");
                toggleRegister = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
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
                txtFirstName.Visible = false; txtLastName.Visible = false; txtEmail.Visible = false; txtPassword.Visible = false; cbAdmin.Visible = false; 
                btnShowRegister.Visible = true;
                persons.getData();
            } else //if unsuccesful
            {
                MessageBox.Show("Something went wrong while communicating trough database.");
            }


        }

        private void btnShowTaskCreate_Click(object sender, EventArgs e)
        {
            var controls = new List<Control> { btnCreateTask, txtName, txtDescription, lblCycle, lblDueDate, lblPerson, lblStartDate, dtpStartDate, dtpDueDate, nudCycle, cbPerson };

            //show and hide right fields
            if (toggleCreateTask)
            {
                toggleVisibility(true, controls, btnShowTaskCreate, "Cancel task creation");
                toggleCreateTask = false;
            }
            else if (!toggleCreateTask)
            {
                toggleVisibility(false, controls, btnShowTaskCreate, "Create new task");
                toggleCreateTask = true;
            }
        }
    }
}
