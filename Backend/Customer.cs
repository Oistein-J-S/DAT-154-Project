using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class Customer
    {


        int Id { get; set; }

        string FirstName { get; set; }
        string LastName { get; set; }
        int Balance { get; set; }

        public Customer(string firstName, string lastName, int balance)
        {
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }
    }
}
