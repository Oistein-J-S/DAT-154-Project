using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectContainerDLL
{
    /**
     * Base customer class. Used with bookings
     */
    class Customer
    {
        private int id;
        private string firstName;
        private string lastName;
        private int balance;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Balance { get => balance; set => balance = value; }

        // TODO pasword

        public Customer(int id, string firstName, string lastName, int balance)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }
    }
}
