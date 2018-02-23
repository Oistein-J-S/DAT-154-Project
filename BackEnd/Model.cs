using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectContainerDLL;

namespace Backend
{
    /**
     * Enteprise logic class
     * On create: create new DB manager (cascading creation)
     */
    class Model
    {
        //Declarations
        private Hotel hotel;


        //Creator
        public Model()
        {
            var db = new HotelContext();
            DbInitializer.Initialize(db);
        }

        //TODO functions
        //TODO Conect to DB
        public bool MakeReservation(int roomNumber, DateTime from, DateTime to, string fName, string lName)
        {   
            return false;
        }

        public List<Booking> GetBookings(DateTime from = DateTime.now, DateTime to = DateTime.now) // Bookings within a period
        {
            return null;
        }

        public List<Booking> GetBookings(int roomNumer) // Bookings asociated with a room
        {
            return null;
        }

        public List<Booking> GetBookings(string romType) // Bookings asociated with room type
        {
            return null;
        }

        public List<Booking> GetBookings(string fName, string lName) // Bookings asociated with a customeer
        {
            return null;
        }

        public List<Room> GetAvailibleRooms(DateTime from = DateTime.now, DateTime to = DateTime.now) //Avalible rooms within date
        {
            return null;
        }

        public List<Room> GetAvailibleRooms(string type, DateTime from = DateTime.now, DateTime to = DateTime.now) // Availible rooms of type within dates
        {
            return null;
        }

        public List<Room> GetAllRooms() // All roms
        {
            return null;
        }

        public List<Room> GetAllRooms(string type) //All rooms of type
        {
            return null;
        }

        public List<Room> getOccupiedRooms() //Roms that are ocupied
        {
            return null;
        }

        public List<Room> getOccupiedRooms(string Type) //Roms that are ocupied of type
        {
            return null;
        }

        public bool checkIn(Booking book)
        {
            return false;
        }

        public bool checkOut(Booking book)
        {
            return false;
        }

        public int GetDebt(int roomNumber) //get the dept from room scervice etc from a room
        {
            return null;
        }

        public int GetDebt(string fName, string lName) // get the dept from room scervice etc for a customer
        {
            return null;
        }

        public bool RemoveReservation(int romNumber, DateTime from) // Remove a reservation from a room
        {
            return false;
        }

        public Booking GetBooking(int romNumber, DateTime from) // get booking from a room
        {
            return null;
        }

   
        /*
         * Ideas for functions: 
         * "viewBooking" get info from app, search model, return object
         * "raiseIssue" subs to even from desktop and app
         * "payment"
         *  
         */
    }
}
