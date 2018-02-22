using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectContainerDLL
{
    class Employee
    {
        int EmpId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string SSN { get; set; }

        public Employee(string firstName, string lastName, string ssn)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SSN = ssn;
        }
    }
}
