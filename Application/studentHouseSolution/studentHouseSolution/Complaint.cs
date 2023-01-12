using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentHouseSolution
{
    class Complaint
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int PersonId { get; private set; }
        public bool Anonymous { get; private set; }
        public string Timestamp { get; private set; }

        public Complaint(int id, string title, string description, int personId, bool anonymous, string timestamp)
        {
            Id = id;
            Title = title;
            Description = description;
            PersonId = personId;
            Anonymous = anonymous;
            Timestamp = timestamp;
        }

    }
}
