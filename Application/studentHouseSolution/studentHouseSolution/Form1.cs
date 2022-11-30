using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentHouseSolution
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = MOOI-DING\SQLEXPRESS; Initial Catalog = StudentHouseSolutionDB; Integrated Security = True");
        SqlCommand command = new SqlCommand();

        string cmd;
        public Form1()
        {
            InitializeComponent();
        }

        public void RefreshGridView()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    RefreshGridView();
                }
                else if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    cmd = "select * from tbl_task";
                    SqlDataAdapter da = new SqlDataAdapter(cmd, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No tasks found!!");
                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("there is no tasks found!!");
                con.Close();
            }

        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }
    }
}