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

        handlerCSV csv = new handlerCSV();

        DataTable dt;

        public AddComplaintForm()
        {
            InitializeComponent();
            dt = csv.Reader("CSV/Complaints.csv");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(tbTitle.Text.Length == 0)
            {
                MessageBox.Show("Title cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (tbDescription.Text.Length == 0)
            {
                MessageBox.Show("Description cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataRow newRow = dt.NewRow();
            newRow["UserId"] = "0";
            newRow["Date"] = DateTime.Now.ToString("yyyy-MM-dd");
            newRow["Title"] = tbTitle.Text;
            newRow["Description"] = tbDescription.Text;
            dt.Rows.Add(newRow);
            csv.Write("CSV/Complaints.csv");

        }
    }
}
