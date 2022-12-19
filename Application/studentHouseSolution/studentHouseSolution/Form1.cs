using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentHouseSolution
{
    public partial class Form1 : Form
    {
        //Server=myServerName,myPortNumber;Database=myDataBase;User Id = myUsername; Password=myPassword;

      //  SqlConnection con = new SqlConnection(@"Data Source = remotemysql.com; Initial Catalog = StudentHouseSolutionDB; Integrated Security = True");
        SqlConnection con = new SqlConnection(@"Server = remotemysql.com, 3306; Initial Catalog = zVrSE88hjg; User Id = zVrSE88hjg; Password = bBS3PzUuZn;");
        SqlCommand command = new SqlCommand();

        string cmd;
        public Form1()
        {
            InitializeComponent();
            RefreshGridView();
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
                    cmd = "select * from Person";
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


            string date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");


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
                    cmd = "select * from tbl_task where date = '@date'";
                    command.Parameters.Add(new SqlParameter("@date", date));


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
    }
}