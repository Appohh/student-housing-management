using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentHouseSolution
{
    public class Task
    {


        private int id;
        private string name;
        private string description;
        private DateTime dueDate;
        private DateTime startDate;
        private int cycle;
        private int personId;
        private int status;
        private DateTime timeStamp;

        public Task(int id, string name, string description, DateTime dueDate, DateTime startDate, int cycle, int personId, int status, DateTime timeStamp)
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
