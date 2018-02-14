using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class Issue
    {
        bool InProgress;
        string Description { get; set; }
        DateTime Completed { get; set; }

        public Issue(string description)
        {
            Description = description;
            InProgress = false;
        }



        public void Resolve()
        {
            Completed = DateTime.Now;
        }
    }

}
