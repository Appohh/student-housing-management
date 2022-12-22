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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
            taskDatabase tasks = new taskDatabase();
            tasks.getData();

            if (tasks.getTasks().Count > 0)
            {
                foreach(var task in tasks.getTasks())
                {
                    addTaskLabel(task.name, task.description, task.dueDate, task.status.ToString());
                }
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



        public void addTaskLabel(string title, string description, string duedate, string status)
        {
            Label lbl = new Label();
            lbl.Text = title + "\r\n\r\n" + description + "\r\n\r\nDue date: " + duedate +"\r\n\r\nStatus: " + status + "\r\n";
            lbl.BackColor = Color.RoyalBlue;
            lbl.Font = new Font("ROG Fonts", 12);
            lbl.AutoSize = false;
            lbl.Size = new Size(614, 289);
            lbl.Margin = new Padding(10);
            flowLayoutPanel1.Controls.Add(lbl);

        }
    }
}