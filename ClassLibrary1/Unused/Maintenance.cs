using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Maintenance : Employee
    {
        public Maintenance(string firstName, string lastName, string ssn) : base(firstName, lastName, ssn)
        {
            
        }
        //Model returns issues, alternatively could give list of rooms with issues
        //public List<Task> GetIssues() { }
        public void StartIssue(Issue issue) { }
        public void ResolveIssue(Issue issue) { }

        //Model generates a task object
        public void RaiseIssue(Room room, String issueDescription) { }
    }

}
