using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class Service : Employee
    {
        public Service(string firstName, string lastName, string ssn) : base (firstName, lastName, ssn)
        {

        }
        public List<Order> GetServiceOrders() { }
        public void CompleteOrder(Order order) { }
    }
}