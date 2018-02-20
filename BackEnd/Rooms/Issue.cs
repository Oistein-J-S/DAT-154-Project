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
        string Description { get; set; }
        DateTime Created { get; }
        DateTime Completed { get; set; }
        
        public Issue(string description)
        {
            Description = description;
            Created = DateTime.Today;
        }

        public void Resolve()  // Resolves the issue making it inactive
        {
            Completed = DateTime.Now;
        }
    }

}
