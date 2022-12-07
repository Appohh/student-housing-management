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
    public partial class CSV : Form
    {
        public CSV()
        {
            InitializeComponent();
        }

        public void CSVread()
        {
           

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            handlerCSV csv = new handlerCSV();
            
            foreach(var item in csv.Read())
            {
                string itemString = "";

                foreach (var item2 in item) {
                    itemString += item2.ToString();
                }
                lbResult.Items.Add(itemString);


            }


        }
    }
}
