using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectContainerDLL
{
    /**
     * Base customer class. Used with bookings
     */
    public class Customer
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Balance { get; set; }
        private string Pwd { get; set; }

        // TODO pasword

        public Customer(int id, string firstName, string lastName, string pwd, int balance)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
            Pwd = pwd;
        }
    }
}
