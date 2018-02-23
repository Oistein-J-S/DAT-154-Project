using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectContainerDLL;

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
         * "searchBooking" takes info from event, sends info to model, model returns list, send event with list
         * "viewBooking" get info from app, search model, return object
         * "raiseIssue" subs to even from desktop and app
         * "payment"
         *  
         *  
         *  
         *  
         *  Trenger:  
        Metode som gir en liste over bookinger List<Booking> med parameter Date fra og Date til
        Metode for opprettelse av Issue på rom DONE (Also completing it)
        Metode for opprettelse av Order på booking eller rom, usikker på hva som er mest logisk DONE
        Metode for lagring av ny booking   DONE
        Metode for endring av booking       DONE
        Metode for sletting av booking      DONE
        Metode for å få alle rom i List<Room>  DONE
        CheckIn     DONE
        CheckOut    DONE
         */

        /**
         * This method fetches the list of all rooms and returns them.
         */
        public List<Room> getAllRooms()
        {
            return null;
        }

        /**
         * This method takes in all relevant info from the view, and sends it to Model to create a new Booking.
         * It returns true if this succeeded, false otherwise.
         */
        private bool createBooking()
        {
            return false;
        }

        /**
         * This method takes in the selected booking and make the described changes to it.
         * Returns true if successfull, false otherwise.
         */
        private bool changeBooking()
        {
            return false;
        }

        /**
         * This method deletes the specified Booking, and returns true if successfull, false otherwise.
         */
        private bool deleteBooking()
        {
            return false;
        }

        /**
         * This method takes info from the view (Desktop or app) and sends it to the model to create a new Issue.
         */
        private bool createIssue()
        {
            return false;
        }

        /**
         * This method takes the specified issue and notifies the Model that it is completed. 
         * Returns true if the process completed successfully, false otherwise.
         */
        private bool completeIssue()
        {
            return false;
        }

        /**
         * This method creates a new Order and adds it to the relevant booking.
         * Returns true if successfull, false otherwise.
         */
        private bool createOrder(Booking booking)
        {
            return false;
        }

        /**
         * This method deletes the specified order from the specified booking.
         * Returns true if successfull, false otherwise.
         */
        private bool deleteOrder(Order order, Booking booking)
        {
            return false;
        }

        /**
         * This method is intended to fetch the list containing all Bookings that have a CheckIn date equal to today.
         */
        private List<Booking> getCheckIn()
        {
            return null;
        }

        /**
         * This method is intended to fetch the list containing all Bookings that have a CheckOut date equal to today.
         */
        private List<Booking> getCheckOut()
        {
            return null;
        }

        /**
         * This method takes a Booking and notes that the customer has checked in. 
         * Returns true if successfull, false otherwise.
         */
        private bool checkIn(Booking booking)
        {
            return false;
        }

        /**
         * This method takes a Booking and notes that the customer has checked out. 
         * Returns true if successfull, false otherwise.
         */
        private bool checkOut(Booking booking)
        {
            
            return false;
        }
    }
}
