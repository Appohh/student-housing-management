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
            // assign gridview datasource property by datatable
            dgData.DataSource = dtShownData;



        }

        private void mcCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DataTable dt = new DataTable();

            string date = mcCalendar.SelectionRange.Start.ToString("yyyy-MM-dd");


            //display row in datagridview
            DataRow row = csv.searchDate(date);
            dgData.DataSource = null;
            dgData.ColumnCount = 4;
            dgData.Columns[0].Name = "Test1";
            dgData.Columns[1].Name = "Test1";
            dgData.Columns[2].Name = "Test1";
            dgData.Columns[3].Name = "Test1";

            dgData.Rows.Add(new object[] { "dsa", "string1", "sa" });
            dgData.Rows.Add(new object[] { false, "string2" });
            dgData.Rows.Add(row);
        }
    }
}
