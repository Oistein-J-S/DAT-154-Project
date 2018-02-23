using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectContainerDLL
{
    /**
     *A maintenence problem for a room. 
     */
    public class Issue
    {
        // Properties
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }

        public Issue(string description)
        {
            this.Description = description;
            Created = DateTime.Now;
        }

        /**
         * Alter the description of an unfinished maintenence task
         */
        public bool changeDescription(string description)
        {
            if (!Completed.HasValue)//the maintenence is not complete
            {
                Description = description;
                return true;
            }
            // can not change a finished task
            return false;
        }
        
        public void Resolve()  // Resolves the issue making it inactive
        {
            Completed = DateTime.Now;
        }
    }

}
