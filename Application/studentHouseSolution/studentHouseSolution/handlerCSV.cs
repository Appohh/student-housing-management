using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentHouseSolution
{
    public class handlerCSV
    {
        public List<string[]> Read()
        {
        //    OpenFileDialog opf = new OpenFileDialog();
       //     opf.Filter = "csv File|*.csv";
       //     if (opf.ShowDialog() == DialogResult.OK)
      //      {
                string[] lines = System.IO.File.ReadAllLines("C:\\Users\\alpay\\Downloads\\testcsv.csv");
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
    }
}
