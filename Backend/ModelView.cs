using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    /**
     * Connects to the views
     * on create: create new modell (cascading creation)
     */
    public class ModelView
    {
        //Declarations
        private Model model;

        //TODO Creator
        public ModelView()
        {
            model = new Model();

        }
        //TODO functions



        /*
         * Ideas for functions:
         * "getFreeRoom" returns list of room with no booking
         * "getOccupiedRoom" returns list of room with booking
         * "makeBooking" takes in info (subs to event from views) from views (web + desktop), sends it to Model for use
         * "checkIn" and "checkOut" 
         * "deleteBooking"
         * "searchBooking" takes info from event, sends info to model, model returns list, send event with list
         * "viewBooking" get info from app, search model, return object
         * "raiseIssue" subs to even from desktop and app
         * "payment"
         *  
         */ 

    }
}
