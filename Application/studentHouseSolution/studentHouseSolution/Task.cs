using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentHouseSolution
{
    public class Task
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public string description { get; private set; }
        public string dueDate { get; private set; }
        public string startDate { get; private set; }
        public int cycle { get; private set; }
        public int personId { get; private set; }
        public int status { get; private set; }
        public string timeStamp { get; private set; }

        public Task(int id, string name, string description, string dueDate, string startDate, int cycle, int personId, int status, string timeStamp)
        {
            this.id = id;
            this.name = name;   
            this.description = description;
            this.dueDate = dueDate;
            this.startDate = startDate;
            this.cycle = cycle;
            this.personId = personId;
            this.status = status;
            this.timeStamp = timeStamp;         
        }


    }
}
