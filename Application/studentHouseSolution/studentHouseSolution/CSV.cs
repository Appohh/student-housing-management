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
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "csv File|*.csv";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                string[] lines = System.IO.File.ReadAllLines(opf.FileName);
                string[][] data = new string[lines.Length][];
                int i = 0;
                foreach (string line in lines)
                {
                    data[i] = line.Split(txtDel.Text.ToCharArray());
                    i++;
                }
                var dd = data.ToList().ToList();
            }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            CSVread();
        }
    }
}
