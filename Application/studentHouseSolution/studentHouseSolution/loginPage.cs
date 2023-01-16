using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace studentHouseSolution
{

    public partial class loginPage : Form
    {
        personDatabase persons = new personDatabase();
        public loginPage()
        {
            InitializeComponent();
            persons.getData();


            FileStream? fileStream = null;


            string email;
            string password;

            try
            {
                fileStream = new FileStream("login.txt", FileMode.OpenOrCreate, FileAccess.Read);
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    if (reader.EndOfStream) return;
                    email = reader.ReadLine();
                    if (reader.EndOfStream) return;
                    password = reader.ReadLine();
                }
               
            }
            finally
            {
                if(fileStream != null)
                    fileStream.Close();
            }

            if(MessageBox.Show($"Log in with {email}?", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                TryLogIn(email, password, false);
            }

        }


        private bool TryLogIn(string email, string password, bool storePassword)
        {
            foreach (var person in persons.getPersons())
            {
                if (person.email == email && person.passwordHash == password)
                {
                    if (storePassword)
                    {

                        FileStream? fileStream = null;
                        try
                        {
                            fileStream = new FileStream("login.txt", FileMode.OpenOrCreate, FileAccess.Write);

                            using (StreamWriter writer = new StreamWriter(fileStream))
                            {
                                writer.WriteLine(email);
                                writer.WriteLine(password);
                            }
                        }
                        finally
                        {
                            if (fileStream != null)
                                fileStream.Close();
                        }
                    }

                    if (person.role == 0)
                    {
                        //MessageBox.Show("Login succes, welcome " + person.firstName + " " + person.lastName + "!");
                        this.Hide();
                        Dashboard f1 = new Dashboard(person);
                        f1.ShowDialog();
                        this.Close();
                        return true;
                    }
                    else if (person.role == 1)
                    {
                        //MessageBox.Show("Login succes, welcome " + person.firstName + " " + person.lastName + "!");
                        this.Hide();
                        Admin f1 = new Admin(person);
                        f1.ShowDialog();
                        this.Close();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong, please contact an admin or try again.");
                    }

                }

            }
            MessageBox.Show("Login not correct");
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            TryLogIn(email, password, cbKeepMeLogged.Checked);
            
        }
    }
}
