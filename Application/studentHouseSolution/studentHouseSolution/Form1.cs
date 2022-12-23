using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        //get current date
        static DateTime currentDT = DateTime.Now;
        static int currentYear = currentDT.Year;
        static int currentMonth = currentDT.Month;
        //Link selected date with SQL 
        string selectedDate = Form1.staticMonth + "/" + UserControlDays.staticDays + "/" + Form1.staticYear;
        public static string date1 = "";
        
        public static int staticMonth , staticYear;

        

        public Form1(Person loggedInUser)
        {
            InitializeComponent();
            taskDatabase tasks = new taskDatabase();
            tasks.getData();

            lblLoggedInUser.Text = loggedInUser.firstName + " " + loggedInUser.lastName;


            if (tasks.getTasks().Count > 0)
            {
                foreach(var task in tasks.getTasks())
                {
                    addTaskLabel(task.name, task.description, task.dueDate, task.status.ToString());
                }
            }

        }

        public void changeDateTxt(string date)
        {
           txt_selected.Text = date;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //Call function to create and load panels
            displayDays();

        }
        private void displayDays()
        {
           //Create and load panels 

            DateTime now = DateTime.Now;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(currentMonth);
            Lbl_Date.Text = monthname + " " + currentYear;


            staticMonth = currentMonth;
            staticYear = currentYear;

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
            staticMonth = currentMonth;
            staticYear = currentYear;

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
            staticMonth = currentMonth;
            staticYear = currentYear;

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
