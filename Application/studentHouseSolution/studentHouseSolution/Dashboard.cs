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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;


namespace studentHouseSolution
{
    public partial class Dashboard : Form
    {

        //get current date
        static DateTime currentDT = DateTime.Now;
        static int currentYear = currentDT.Year;
        static int currentMonth = currentDT.Month;
        public static string date1 = "";
        
        public static int staticMonth , staticYear;
        taskDatabase tasks = new taskDatabase();
        personDatabase persons = new personDatabase();
        Person loggedInUser;



        public Dashboard(Person userLoggedIn)
        {
            InitializeComponent();
            tasks.getData();
            persons.getData();
            loggedInUser = userLoggedIn;
            lblLoggedInUser.Text = loggedInUser.firstName + " " + loggedInUser.lastName;

            if (UpdateCyclicTasks())
            {
                tasks.getData();
                persons.getData();
            }

            showAllTasks();

        }

        bool UpdateCyclicTasks()
        {
            bool wasUpdated = false;
            List<Task> cyclicTaskList = tasks.getTasks().Where(t => t.cycle != 0).ToList();
            foreach(Task task in cyclicTaskList)
            {
                DateTime dueDate = DateTime.Parse(task.dueDate);
                if(dueDate <= DateTime.Now || task.status == 1)
                {
                    do
                        dueDate = dueDate.AddDays(7);
                    while (dueDate <= DateTime.Now);
                    tasks.changeTaskDueDate(task.id.ToString(), dueDate);
                    wasUpdated = true;
                }
            }

            return wasUpdated;
        }

        public void changeDateTxt(string date)
        {
           txt_selected.Text = date;
        }

        public void showAllTasks()
        {
            flowLayoutPanel1.Controls.Clear();
            if (tasks.getTasks().Count > 0)
            {
                foreach (var task in tasks.getTasks())
                {
                    //get name of personid
                    Person personFit = null;
                    foreach (var person in persons.getPersons())
                    {
                        if (task.personId == person.id) { personFit = person; }
                    }

                    //add label to flowpanelview
                    addTaskLabel(task.id, task.name, task.description, task.startDate, task.dueDate, personFit, task.status, task.cycle);
                }
            }
        }


        bool AreFallingInSameWeek(DateTime a, DateTime b)
        {
            return a.AddDays(7 - (int)a.DayOfWeek).Date.Equals(b.AddDays(7 - (int)b.DayOfWeek).Date);
        }


        public void addTaskLabel(int taskId, string title, string description, string startdate, string duedate, Person person, int status, int cyclic)
        {
            //set user friendly text for status tiny-int
            string statusText = "";
                if ( status == 0) { statusText = "Not done"; } else if (status == 1) { statusText = "Done"; }

            //add new label
            Label lbl = new Label();
            lbl.Text = title + "\r\n\r\n" + description + "\r\n\r\nStartdate : " + startdate.Substring(0,10) + "\r\n\r\nDue date: " + duedate + "\r\n\r\nPerson: " + person.firstName + " " + person.lastName +"\r\n\r\nStatus: " + statusText + "\r\n\r\n:)";
            lbl.BackColor = Color.RoyalBlue;
            lbl.Font = new Font("ROG Fonts", 12);
            lbl.ForeColor = Color.White;
            lbl.AutoSize = false;
            lbl.Size = new Size(614, 340);
            lbl.Margin = new Padding(10);


            DateTime dueTime = DateTime.Parse(duedate);

            bool isCyclic = cyclic != 0;

            bool cyclicAndTaskWeek = !isCyclic | AreFallingInSameWeek(dueTime, DateTime.Now);

            //if status == 0 make button to check the task and check if for logged in person
            if (status == 0 && person.id == loggedInUser.id && cyclicAndTaskWeek)
            {
                Button btn = new Button();
                btn.Name = "tester";
                btn.Location = new Point(0, 305);
                btn.BackColor = Color.White;
                btn.Size = new Size(150, 30);
                btn.Text = "Check";
                btn.ForeColor = Color.Black;
                //add to label
                lbl.Controls.Add(btn);
                //set a tag to send value
                btn.Tag = taskId.ToString();
                //add new evenhandler as panelbtn_click so we can handle click
                btn.Click += new EventHandler(panelBtn_Click);
                
            }
            //add whole label to flowlayoutpanel
            flowLayoutPanel1.Controls.Add(lbl);
        }

        private void panelBtn_Click(object sender, EventArgs e)
        {
            //set specific clicked button:
            Button btn = (Button)sender;
            //check task in db
            try { tasks.checkTask(btn.Tag.ToString()); MessageBox.Show("Check ;)");  } catch { MessageBox.Show("Something went wrong, try again another time or contact an admin."); }
            //refresh object data
            tasks.getData();
            if(UpdateCyclicTasks())
                tasks.getData();
            //refresh task list
            showAllTasks();
            
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

            //create the panels on the right order
            int daysoftheweek = (int)startofthemonth.DayOfWeek == 0 ? 7 : (int)startofthemonth.DayOfWeek;
            for (int i=1;i<daysoftheweek; i++)
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

        private void btnGetAllTasks_Click(object sender, EventArgs e)
        {
            showAllTasks();

        }

        private void btnGetMyTasks_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (tasks.getTasks().Count > 0)
            {
                foreach (var task in tasks.getTasks())
                {

                    if (task.personId == loggedInUser.id)
                    {
                        addTaskLabel(task.id, task.name, task.description, task.startDate, task.dueDate, loggedInUser, task.status, task.cycle);
                    }
                }
            }

        }

        //specific date click -> show date specific tasks:
        private void txt_selected_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (tasks.getTasks().Count > 0)
            {
                foreach (var task in tasks.getTasks())
                {
                    //format dates
                    DateTime startdate = DateTime.Parse(task.startDate);

                    DateTime duedate = DateTime.Parse(task.dueDate);

                    DateTime selecteddate = DateTime.ParseExact(txt_selected.Text, "d-M-yyyy", CultureInfo.InvariantCulture);

                    //check if date between start and due dates
                    if (selecteddate >= startdate && selecteddate <= duedate)
                    {
                        Person personFit = null;
                        foreach (var person in persons.getPersons())
                        {
                            if (task.personId == person.id) { personFit = person; }
                        }


                        addTaskLabel(task.id, task.name, task.description, task.startDate, task.dueDate, personFit, task.status, task.cycle);
                    }
                }
            }
        }

        private void btnAddComplaint_Click_1(object sender, EventArgs e)
        {
            AddComplaintForm form = new AddComplaintForm(loggedInUser);
            form.ShowDialog();
        }

        private void btnSeeComplaints_Click_1(object sender, EventArgs e)
        {
            SeeComplaintsForm form = new SeeComplaintsForm(loggedInUser);
            form.ShowDialog();
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
