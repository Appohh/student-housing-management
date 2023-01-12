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

    public partial class loginPage : Form
    {
        personDatabase persons = new personDatabase();
        public loginPage()
        {
            InitializeComponent();
            persons.getData();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            foreach (var person in persons.getPersons())
            {
                if (person.email == email && person.passwordHash == password)
                {
                    if (person.role == 0)
                    {
                        //MessageBox.Show("Login succes, welcome " + person.firstName + " " + person.lastName + "!");
                        this.Hide();
                        Dashboard f1 = new Dashboard(person);
                        f1.ShowDialog();
                        this.Close();
                    }
                    else if (person.role == 1)
                    {
                        //MessageBox.Show("Login succes, welcome " + person.firstName + " " + person.lastName + "!");
                        this.Hide();
                        Admin f1 = new Admin(person);
                        f1.ShowDialog();
                        this.Close();
                    } else
                    {
                        MessageBox.Show("Something went wrong, please contact an admin or try again.");
                    }

                } 

            }
            MessageBox.Show("Login not correct");
        }
    }
}
