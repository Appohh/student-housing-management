using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentHouseSolution
{
    public class Person
    {
        public int id { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string passwordHash { get; private set; }
        public string email { get; private set; }
        public int role { get; private set; }
        public string timeStamp { get; private set; }

        public Person(int id, string firstName, string lastName, string passwordHash, string email, int role, string timeStamp)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.passwordHash = passwordHash;
            this.email = email;
            this.role = role;
            this.timeStamp = timeStamp;
        }
    }
}
