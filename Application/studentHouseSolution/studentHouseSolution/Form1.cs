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
using MySqlX.XDevAPI.Relational;


namespace studentHouseSolution
{
    public partial class Form1 : Form
    {

        //get current date
        static DateTime currentDT = DateTime.Now;
        static int currentYear = currentDT.Year;
        static int currentMonth = currentDT.Month;
        //Link selected date with SQL 
        string selected_date = Form1.static_month + "/" + UserControlDays.static_days + "/" + Form1.static_year;
        public static string date1 = "";
        
        public static int static_month , static_year;

        

        //SqlConnection con = new SqlConnection(@"Data Source = MOOI-DING\SQLEXPRESS; Initial Catalog = StudentHouseSolutionDB; Integrated Security = True");
        //SqlConnection con = new SqlConnection(@"Server = db4free.net; Database = studenthousing; Uid = studenthousing; Pwd = studenthousing;");
        MySqlConnection con = new MySqlConnection("Server = db4free.net; Database = studenthousing; Uid = studenthousing; Pwd = studenthousing;");
        MySqlCommand command = new MySqlCommand();

        string cmd;
        public Form1()
        {
            InitializeComponent();
            Task tasks = new Task();
            tasks.Read();
            if (tasks.getTasks().Rows.Count > 0)
            {
                dataGridView1.DataSource = tasks.getTasks();
            }

        }

        public void changeDateTxt(string date)
        {
           txt_selected.Text = date;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl.Text = "Clean Trash\r\n\r\nfdsagdsagdsag gfsdgfdsg g fdsgfdsg sgsfdg \r\ngfsdgdsf gfsdg gfsdgfsdg gfsdgfsd gfsd\r\ngfsdgsd gfsdgfsd\r\n\r\nDue date: 12/3/2000\r\n\r\nStatus: To do\r\n";
            lbl.BackColor = Color.DodgerBlue;
            lbl.Font = new Font("ROG Fonts", 12);
            lbl.AutoSize = false;
            lbl.Size = new Size(614, 289);
            lbl.Margin = new Padding(10);
            flowLayoutPanel1.Controls.Add(lbl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();

        }
        private void displayDays()
        {
            

            DateTime now = DateTime.Now;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(currentMonth);
            Lbl_Date.Text = monthname + " " + currentYear;


            static_month = currentMonth;
            static_year = currentYear;

            //get the current month and year
            DateTime startofthemonth = new DateTime(currentYear, currentMonth, 1);
            int days = DateTime.DaysInMonth(currentYear, currentMonth);
            
            //create the panels
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for(int i=1;i<daysoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            //imports the days numbers to the panels
            for (int i = 1;i<= days;i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {

            daycontainer.Controls.Clear();
            static_month = currentMonth;
            static_year = currentYear;

            if (currentMonth >= 12)
            {
                currentYear++;
                currentMonth = 1;
            }
            else { currentMonth += 1; }
            
            displayDays();
           
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            static_month = currentMonth;
            static_year = currentYear;

            if (currentMonth <= 1)
            {
                currentMonth = 12;
                currentYear--;
            }
            else { currentMonth -= 1; }
            displayDays();
        }
    }
}