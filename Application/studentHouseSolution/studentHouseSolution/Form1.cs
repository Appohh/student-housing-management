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