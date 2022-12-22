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
    public partial class UserControlDays : UserControl
    {
        public static string static_days;
        


        public UserControlDays()
        {
            InitializeComponent();
        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_days = lbdays.Text;
            //EventForm eventForm = new EventForm();
            //eventForm.Show();
            Form1.date1 = Form1.static_month + "/" + UserControlDays.static_days + "/" + Form1.static_year;
            
             
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
    }
}
