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
    public partial class AddComplaintForm : Form
    {

        complaintsDatabase cdb;
        Person user;

        public AddComplaintForm(Person user)
        {
            InitializeComponent();
            cdb = new complaintsDatabase();
            this.user = user;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(tbTitle.Text.Length == 0)
            {
                MessageBox.Show("Title cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbDescription.Text.Length == 0)
            {
                MessageBox.Show("Description cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cdb.AddComplaint(user.id, tbTitle.Text, tbDescription.Text, cbAnonymous.Checked);
            Close();


        }
    }
}
