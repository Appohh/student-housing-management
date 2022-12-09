using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentHouseSolution
{
    public partial class CSV : Form
    {
        handlerCSV csv = new handlerCSV();

        public CSV()
        {
            InitializeComponent();
        }

        public void CSVread()
        {
           

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            List<string> taskData = new List<string>();

            foreach (var item in csv.Read())
            {
                string itemString = "";

                foreach (var item2 in item) {
                    itemString += item2.ToString();
                }
                lbResult.Items.Add(itemString);
                taskData.Add(itemString);


            }

            dgData.DataSource = taskData;


            // assign gridview datasource property by datatable
            dgData.DataSource = csv.Reader("C:\\Users\\alpay\\Downloads\\testcsv.csv");

            // bind the gridview
    //        dgData.DataBind();



        }

        private void mcCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            string date = mcCalendar.SelectionRange.Start.ToString("yyyy-MM-dd");


            csv.searchDate(date);
        }
    }
}
