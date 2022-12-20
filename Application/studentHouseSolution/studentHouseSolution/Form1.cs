using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace studentHouseSolution
{
    public partial class Form1 : Form
    {



        //SqlConnection con = new SqlConnection(@"Data Source = MOOI-DING\SQLEXPRESS; Initial Catalog = StudentHouseSolutionDB; Integrated Security = True");
        //SqlConnection con = new SqlConnection(@"Server = db4free.net; Database = studenthousing; Uid = studenthousing; Pwd = studenthousing;");
        MySqlConnection con = new MySqlConnection("Server = db4free.net; Database = studenthousing; Uid = studenthousing; Pwd = studenthousing;");
        MySqlCommand command = new MySqlCommand();


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
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd, con);
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
                    command.Parameters.Add(new MySqlParameter("@date", date));


                    MySqlDataAdapter da = new MySqlDataAdapter(cmd, con);
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

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = null;
            MySqlConnection cnn;
            connectionString = "Server = db4free.net; Database = studenthousing; Uid = studenthousing; Pwd = studenthousing;";
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                MessageBox.Show(ex.ToString());


            }
        }
    }
}