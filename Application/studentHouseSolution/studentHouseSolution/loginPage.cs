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
                    MessageBox.Show("Login succes");
                    this.Hide();
                    Form1 f1 = new Form1(person);
                    f1.ShowDialog();
                    this.Close();

                } 
                else
                {
                    MessageBox.Show("Login not correct");
                }

            }

        }
    }
}
