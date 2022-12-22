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
        public static string staticDays;
        


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
            staticDays = lbdays.Text;
            //EventForm eventForm = new EventForm();
            //eventForm.Show();

            Form1 parent = (Form1)this.Parent.Parent;

            Form1.date1 = Form1.static_month + "/" + UserControlDays.staticDays + "/" + Form1.static_year;
            parent.changeDateTxt(Form1.date1);
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
    }
}
