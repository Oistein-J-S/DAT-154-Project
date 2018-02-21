using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    /**
     *A maintenence problem for a room. 
     */
    class Issue
    {
        //Declarations
        private string description;
        private DateTime created;
        private DateTime? completed;

        // Properties
        public string Description { get => description;}
        public DateTime Created { get => created;}
        public DateTime? Completed { get => completed;}

        public Issue(string description)
        {
            this.description = description;
            created = DateTime.Today;
        }

        /**
         * Alter the description of an unfinished maintenence task
         */
        public bool changeDescription(string description)
        {
            if (!completed.HasValue)//the maitenence is not complete
            {
                this.description = description;
                return true;
            }
            // can not change a finished task
            return false;
        }
        
        public void Resolve()  // Resolves the issue making it inactive
        {
            completed = DateTime.Now;
        }
    }

}
