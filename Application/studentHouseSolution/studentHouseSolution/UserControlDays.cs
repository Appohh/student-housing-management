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

            Dashboard parent = (Dashboard)this.Parent.Parent;

            Dashboard.date1 = UserControlDays.staticDays + "-" + Dashboard.staticMonth + "-" + Dashboard.staticYear;
            parent.changeDateTxt(Dashboard.date1);
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
    }
}
