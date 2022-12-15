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

        DataTable dtShownData;

        public CSV()
        {
            InitializeComponent();

            dtShownData = csv.Reader("C:\\Users\\alpay\\Downloads\\testcsv.csv");
        }

        public void CSVread()
        {
           

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //LIST METHOD:
           /* List<string> taskData = new List<string>();

            foreach (var item in csv.Read("AA"))
            {
                string itemString = "";

                foreach (var item2 in item) {
                    itemString += item2.ToString();
                }
                lbResult.Items.Add(itemString);
                taskData.Add(itemString);


            } 

            dgData.DataSource = taskData; */


            // assign gridview datasource property by datatable
            dgData.DataSource = dtShownData;



            // bind the gridview
            // dgData.DataBind();
        }

        private void mcCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DataTable dt = new DataTable();

            string date = mcCalendar.SelectionRange.Start.ToString("yyyy-MM-dd");


            //display row in datagridview
            DataRow row = csv.searchDate(date);


        }
    }
}
