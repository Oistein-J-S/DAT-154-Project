using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    /**
     *A maintenence problem for a room. 
     */
    class Issue
    {
        //bool InProgress;
        string Description { get; set; }
        DateTime Completed { get; set; }
        DateTime Created {get;}

        public Issue(string description)
        {
            //InProgress = false;
            Description = description;
            Created = DateTime.Today;
        }

        public void Resolve()
        {
            Completed = DateTime.Now;
        }
    }

}
