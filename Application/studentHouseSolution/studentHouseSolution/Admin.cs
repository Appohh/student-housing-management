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
        public Admin(Person userLoggedIn)
        {
            InitializeComponent();

            tasks.getData();
            persons.getData();
            loggedInUser = userLoggedIn;   
        }

        private void btnShowRegister_Click(object sender, EventArgs e)
        {
            //show and hide right fields
            txtFirstName.Visible = true;txtLastName.Visible = true;txtEmail.Visible = true;txtPassword.Visible = true; cbAdmin.Visible = true;
            btnShowRegister.Visible = false;
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
    }
}
