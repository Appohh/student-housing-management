using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentHouseSolution
{
    public class handlerCSV
    {
        //datatable with all data
        private DataTable dt = new DataTable();

        //datalist with data
        public List<string[]> Read(string filename)
        {
            //file prompt:
            //    OpenFileDialog opf = new OpenFileDialog();
            //     opf.Filter = "csv File|*.csv";
            //     if (opf.ShowDialog() == DialogResult.OK)
            //      {
            string[] lines;
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                lines = System.IO.File.ReadAllLines(ofd.FileName);
            }
            else
            {
                return null;
            }
            string[][] data = new string[lines.Length][];
            int i = 0;
            foreach (string line in lines)
            {
                data[i] = line.Split(",".ToCharArray());
                i++;
            }
            var dd = data.ToList().ToList();

            return dd;
        }

        public DataTable Reader(string file_path)
        {
            //  get all lines of csv file
            string[] str = System.IO.File.ReadAllLines(file_path);

            // get the column header means first line
            string[] temp = str[0].Split(',');

            // creates columns of gridview as per the header name
            foreach (string t in temp)
            {
                this.dt.Columns.Add(t, typeof(string));
            }

            // now retrive the record from second line and add it to datatable
            for (int i = 1; i < str.Length; i++)
            {
                string[] t = str[i].Split(',');
                this.dt.Rows.Add(t);
            }

            return this.dt;

        }

        public void Write(string file_path)
        {
            List<string> columnNames = new List<string>();

            foreach(DataColumn dc in dt.Columns)
            {
                columnNames.Add(dc.ToString());
            }

            List<string> csvLines = new List<string>
            {
                String.Join(",", columnNames)
            };
            
            foreach(DataRow dr in dt.Rows)
            {
                csvLines.Add(String.Join(",", dr.ItemArray));
            }

            System.IO.File.WriteAllLines(file_path, csvLines);
        }

        public string? searchDate(string date)
        {
            foreach (DataRow row in this.dt.Rows)
            {
                if (row.ToString() == date)
                {
                    return row.ToString();
                }
            }
            return null;
        }
    }
}
