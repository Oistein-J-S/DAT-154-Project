using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    /**
     * Base customer class. Used with bookings
     */
    class Customer
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int Balance { get; set; }
        // TODO pasword

        public Customer(int id, string firstName, string lastName, int balance)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }
    }
}
